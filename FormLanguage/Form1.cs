using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ConfigurationSettings;
using FormLanguage.Properties;
using System.Globalization;
using System.Threading;
using System.Reflection;
using System.Resources;

namespace FormLanguage
{
    public partial class Form1 : Form
    {
        private string strDefaultLanguage = "";
        private string strDefaultLanguageValue = "";
        private string selectLanguageValue = "";

        public Dictionary<string, string> DClanguage = new Dictionary<string, string>();


        public Form1()
        {
            InitializeComponent();

            //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //// Log it when start loading.
            //ConfigurationSection c = config.GetSection("StartUpConfiguration");

            //StartUpConfigSection section = (StartUpConfigSection)c;

            //string deafultLanguage = section.LanguageConfigure.Default; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoginHelper.LoadConfiguration();
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Log it when start loading.


            StartUpConfigSection section = (StartUpConfigSection)config.GetSection(StartUpConfigSection.XmlConfigKey);

            string deafultLanguage = section.LanguageConfigure.Default;

            strDefaultLanguage =section.LanguageConfigure.Default;
           

            System.Resources.ResourceManager _rm = new System.Resources.ResourceManager("FormLanguage.Properties.Resources", typeof(Resources).Assembly);
            strDefaultLanguageValue = _rm.GetString(strDefaultLanguage.Replace("-", string.Empty));

            List<string> value = new List<string>();
            List<string> Nativevalue = new List<string>();

            if (section.LanguageConfigure.Count > 0)
            {
                // Add locale list.
                foreach (LanguageConfigEntry language in section.LanguageConfigure)
                {
                    value.Add(language.Name);

                    string name = new CultureInfo(language.Name).NativeName;
                    Nativevalue.Add(name);

                    DClanguage.Add(name,language.Name);
                }
            }

            foreach (string language in DClanguage.Keys)
            {
                this.comboBox1.Items.Add(DClanguage[language]);
                // Select current culture language.
                if (language == deafultLanguage)
                {
                    this.comboBox1.SelectedItem = DClanguage[language];
                    selectLanguageValue = language;
                }
            }

            this.cbxLanguage.DataSource = Nativevalue;
            this.cbxLanguage.SelectedItem = new CultureInfo(deafultLanguage).NativeName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string key = "zh-CN";
            string value = cbxLanguage.Text;

            string key = DClanguage[value];
            //if (!string.IsNullOrEmpty(strDefaultLanguage))
            //{
            //   key = strDefaultLanguage;
            //}

             //System.Resources.ResourceManager _rm = new System.Resources.ResourceManager("StringResources.Resources", typeof(Resources).Assembly);
            //strDefaultLanguageValue = _rm.GetString(strDefaultLanguage.Replace("-", string.Empty));
         
            StringResources.Resources.Culture = new CultureInfo(key);

            //string name = StringResources.Resources.Culture.NativeName;

            string name = new CultureInfo(key).NativeName;

            ResourceManager _rm = StringResources.Resources.ResourceManager;

            //UtilCulture.InitialResource(StringResources.Resources.ResourceManager);

            //ResourceManager _rm = new ResourceManager("StringResources.Resource", Assembly.GetExecutingAssembly());

            Thread.CurrentThread.CurrentUICulture = StringResources.Resources.Culture;

            //this.label1.Text = _rm.GetString("User");         
            //this.label2.Text=  _rm.GetString("Password");

            this.lblUser.Text = _rm.GetString("User");
            this.lblPassword.Text = _rm.GetString("Password");
            this.lblDomain.Text = _rm.GetString("Domain");
            this.lblLanguage.Text = _rm.GetString("Language");

            this.btnExit.Text = _rm.GetString("Exit");
            this.btnLogin.Text = _rm.GetString("Login");
            this.Text = _rm.GetString("UserLogin");
            //this.label1.Text = UtilCulture.GetString("User");         
            //this.label2.Text=  UtilCulture.GetString("Password");
        }


        public sealed class UtilCulture
        {

            #region Variable & Constructor
            private static ResourceManager _rm;

            /// <summary>
            /// Default constructor
            /// 默认构造方法
            /// </summary>
            private UtilCulture() { }
            #endregion

            #region InitialResource
            /// <summary>
            /// Initial resource files
            /// 初始化资源文件
            /// </summary>
            /// <param name="culture">Current culture 当前语种</param>
            public static bool InitialResource(ResourceManager resourceManager)
            {
                _rm = resourceManager;
                return true;
            }
            #endregion

            #region GetString
            /// <summary>
            /// Get resource from resource file by key according to current culture setup
            /// 根据当前语种设置, 获取对应Key值的资源
            /// </summary>
            /// <param name="key">Resource key 资源Key值</param>
            /// <returns></returns>
            public static string GetString(string key)
            {
                try
                {
                    string result = _rm.GetString(key);
                    if (string.IsNullOrEmpty(result)) return key;
                    else return result;
                }
                catch { return key; }
            }
            #endregion

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
