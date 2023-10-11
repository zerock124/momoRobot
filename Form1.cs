using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;

namespace momorobots
{
    public partial class Form1 : Form
    {
        private static IWebDriver? driver;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        /// <summary>
        /// �}���s����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenWeb_Click(object sender, EventArgs e)
        {
            try
            {
                // �}�ұ���x����
                AllocConsole();
                Console.WriteLine("�}���s����, �еy��...");
                // �}���s����, �ø���ܳ]�w����
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(driverService);
                string url = "https://scm.momoshop.com.tw/manage/login.jsp";
                driver.Navigate().GoToUrl(url);
                Console.WriteLine("�}���s��������");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// ����Ƚw�Ƶ{
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActionStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (driver != null)
                {
                    // �]�w�i�ױ��q0�}��
                    progressBar.Value = 0;
                    // �`�ƶq
                    int totalCount = 0;
                    // ���o�Ҧ��ݭn�I���Ƚw���ӫ~
                    var totalProducts = driver.FindElements(By.CssSelector("input[name='btnNotDow']"));
                    // ���o�ݭn����u�Ƚw�v���`�ƶq
                    if (totalProducts != null)
                        totalCount = totalProducts.Count();
                    if (totalCount > 0)
                    {
                        // ���檬�A
                        bool success = false;
                        // �w�g���檺�ƶq
                        int actionCount = 0;
                        while (success == false)
                        {
                            try
                            {
                                IWebElement _btnNotDow = driver.FindElement(By.CssSelector("input[name='btnNotDow']"));
                                if (_btnNotDow != null)
                                {
                                    _btnNotDow.Click();
                                }
                                IWebElement _alertCloseBtn = driver.FindElement(By.Id("alertCloseBtn"));
                                if (_alertCloseBtn != null)
                                {
                                    _alertCloseBtn.Click();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.Write("�I���Ƚw�X�{���~, �нT�{���`���D");
                            }
                            actionCount++;
                            // �i�ױ�
                            labProcess.Text = string.Format("{0} / {1}", actionCount, totalCount);
                            progressBar.Value = actionCount / totalCount;
                            if (progressBar.Value == 100)
                                success = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("�L����ݭn����u�Ƚw�v���ӫ~");
                    }
                }
                else
                {
                    MessageBox.Show("�Х��}���s����");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}