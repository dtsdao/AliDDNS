using Aliyun.Acs.Alidns.Model.V20150109;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using static Aliyun.Acs.Alidns.Model.V20150109.DescribeSubDomainRecordsResponse;

namespace net.nutcore.aliddns
{
    public partial class mainForm : Form
    {
        static IClientProfile clientProfile;
        static DefaultAcsClient client;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("config.xml") != true)
                {
                    saveConfigFile();
                    return;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("文件错误！信息：" + error);
            }

            //Prepare anything we need
            readConfigFile();

            try
            {
                clientProfile = DefaultProfile.GetProfile("cn-hangzhou", accessKeyId.Text, accessKeySecret.Text);
                client = new DefaultAcsClient(clientProfile);
                localIP.Text = getLocalIP();
                domainIP.Text = getDomainIP();
            }
            catch (Exception) { networkStatus.Text = "无网络"; }
        }

        private void readConfigFile()
        {
            string[] config = new string[5];

            int i = 0;

            //Create xml object
            XmlDocument xmlDOC = new XmlDocument();
            xmlDOC.Load("config.xml");
            XmlNodeReader readXML = new XmlNodeReader(xmlDOC);

            while (readXML.Read())
            {
                readXML.MoveToElement();//Forward
                if (readXML.NodeType == XmlNodeType.Text)//Only save config
                {
                    config[i] = readXML.Value;
                    i++;
                }
            }

            accessKeyId.Text = config[0];
            accessKeySecret.Text = config[1];
            recordId.Text = config[2];
            fullDomainName.Text = config[3];
            nextUpdateSeconds.Text = newSeconds.Text = config[4];
        }

        private bool saveConfigFile()
        {
            if (accessKeyId.Text == "" || accessKeySecret.Text == "" || recordId.Text == "" || fullDomainName.Text == "" || newSeconds.Text == "")
            {
                MessageBox.Show("任何值都不能为空！无法填写请输入null或0");
                return false;
            }

            XmlTextWriter textWriter = new XmlTextWriter("config.xml", null);
            textWriter.WriteStartDocument();

            textWriter.WriteComment("AlidnsAutoCheckTool");
            textWriter.WriteComment("Version:Beta 1.0");
            //Start config file
            textWriter.WriteStartElement("Config");

            textWriter.WriteStartElement("AccessKeyID", "");
            textWriter.WriteString(accessKeyId.Text);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("AccessKeySecret", "");
            textWriter.WriteString(accessKeySecret.Text);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("RecordID", "");
            textWriter.WriteString(recordId.Text);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Type", "");
            textWriter.WriteString(fullDomainName.Text);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("WaitingTime", "");
            textWriter.WriteString(newSeconds.Text);
            textWriter.WriteEndElement();


            textWriter.WriteEndElement();

            textWriter.WriteEndDocument();
            textWriter.Close();

            return true;
        }

        private string getLocalIP()
        {
            try
            {
                string strUrl = "http://1212.ip138.com/ic.asp";
                Uri uri = new Uri(strUrl);
                WebRequest webreq = WebRequest.Create(uri);
                Stream s = webreq.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(s, Encoding.Default);
                string all = sr.ReadToEnd();

                //Cut the string
                string[] symbols = new string[2] { "[", "]" };
                string[] data = all.Split(symbols, 30, StringSplitOptions.RemoveEmptyEntries);
                string ip = data[1];
                return ip;
            }
            catch (Exception)
            {
                networkStatus.Text = "无网络";
                return "0.0.0.0";
            }
        }

        private bool setRecordId()
        {
            DescribeSubDomainRecordsRequest request = new DescribeSubDomainRecordsRequest();
            request.SubDomain = fullDomainName.Text;
            try
            {
                DescribeSubDomainRecordsResponse response = client.GetAcsResponse(request);
                List<Record> list = response.DomainRecords;

                if (list.Count == 0)
                {
                    addDomainRecord();
                    return false;
                }

                int i = 0;

                foreach (Record record in list)
                {
                    i++;
                    MessageBox.Show("Record" + i.ToString());
                    recordId.Text = record.RecordId;
                    globalRR.Text = record.RR;
                    globalDomainType.Text = record.Type;
                    globalValue.Text = record.Value;
                }
                return true;
            }
            //处理错误
            catch (ServerException e)
            {
                MessageBox.Show(e.ErrorCode + e.ErrorMessage);

                return false;
            }
            catch (ClientException e)
            {
                MessageBox.Show(e.ErrorCode + e.ErrorMessage);

                return false;
            }
        }

        private string getDomainIP()
        {
            DescribeDomainRecordInfoRequest request = new DescribeDomainRecordInfoRequest();
            request.RecordId = recordId.Text;
            try
            {
                DescribeDomainRecordInfoResponse response = client.GetAcsResponse(request);
                return response.Value;
            }
            //处理错误
            catch (ServerException e)
            {
                MessageBox.Show("Server Exception: " + e.ErrorCode + e.ErrorMessage);
                return "0.0.0.0";
            }
            catch (ClientException e)
            {
                MessageBox.Show("Client Exception: " + e.ErrorCode + e.ErrorMessage);
                return "0.0.0.0";
            }
        }

        private void updateDomainRecord()
        {
            string[] symbols = new string[1] { "." };
            string[] data = fullDomainName.Text.Split(symbols, 30, StringSplitOptions.RemoveEmptyEntries);
            string domainRR = data[0];
            string domainName = data[1] + "." + data[2];

            UpdateDomainRecordRequest request = new UpdateDomainRecordRequest();
            request.Type = "A";
            request.RR = domainRR;
            request.RecordId = recordId.Text;
            request.Value = localIP.Text;
            try
            {
                UpdateDomainRecordResponse response = client.GetAcsResponse(request);
                recordId.Text = response.RecordId;
            }
            //处理错误
            catch (ServerException e)
            {
                MessageBox.Show(e.ErrorCode + e.ErrorMessage);
            }
            catch (ClientException e)
            {
                MessageBox.Show(e.ErrorCode + e.ErrorMessage);
            }
        }

        private void addDomainRecord()
        {
            string[] symbols = new string[1] { "." };
            string[] data = fullDomainName.Text.Split(symbols, 30, StringSplitOptions.RemoveEmptyEntries);
            string domainRR = data[0];
            string domainName = data[1] + "." + data[2];

            AddDomainRecordRequest request = new AddDomainRecordRequest();
            request.Type = "A";
            request.RR = domainRR;
            request.DomainName = domainName;
            request.Value = localIP.Text;
            try
            {
                AddDomainRecordResponse response = client.GetAcsResponse(request);
                recordId.Text = response.RecordId;
            }
            //处理错误
            catch (ServerException e)
            {
                MessageBox.Show(e.ErrorCode + e.ErrorMessage);
            }
            catch (ClientException e)
            {
                MessageBox.Show(e.ErrorCode + e.ErrorMessage);
            }
        }

        private void updatePrepare()
        {
            nextUpdateSeconds.Text = newSeconds.Text;
            try
            {
                localIP.Text = getLocalIP();
                domainIP.Text = getDomainIP();

                if (domainIP.Text != localIP.Text)
                {
                    updateDomainRecord();
                }

                localIP.Text = getLocalIP();
                domainIP.Text = getDomainIP();
            }
            catch (Exception) { networkStatus.Text = "无网络"; }
        }

        //Events in form
        private void updateNow_Click(object sender, EventArgs e)
        {
            updatePrepare();
        }

        private void checkConfig_Click(object sender, EventArgs e)
        {
            try
            {
                clientProfile = DefaultProfile.GetProfile("cn-hangzhou", accessKeyId.Text, accessKeySecret.Text);
                client = new DefaultAcsClient(clientProfile);
                if (setRecordId()) MessageBox.Show("设置正确！");
                if (saveConfigFile()) MessageBox.Show("保存成功！");
            }
            catch (Exception) { networkStatus.Text = "无网络"; }
        }

        private void helpPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://bbs.aliyun.com/read/289624.html");
        }

        private void personalWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.nutcore.net/");
        }

        private void autoUpdateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (autoUpdateOn.Checked == true)
                {
                    int seconds = Convert.ToInt32(nextUpdateSeconds.Text);
                    seconds--;
                    nextUpdateSeconds.Text = seconds.ToString();

                    if (seconds == 0)
                    {
                        updatePrepare();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("请检查设置中的秒数是否为整数！错误信息：" + error);
            }
        }
    }
}
