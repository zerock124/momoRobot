using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace momorobots
{
    public partial class Form1 : Form
    {
        private static IWebDriver? driver;
        public Form1()
        {
            // ��l��
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
                    try
                    {
                        var totalProducts = driver.FindElements(By.CssSelector("input[name='btnNotDow']"));
                        // ���o�ݭn����u�Ƚw�v���`�ƶq
                        if (totalProducts != null)
                            totalCount = totalProducts.Count();
                    }
                    catch
                    {
                        totalCount = 0;
                    }
                    if (totalCount > 0)
                    {
                        // ���檬�A
                        bool success = false;
                        // �w�g���檺�ƶq
                        int actionCount = 0;
                        while (success == false)
                        {
                            // �I���Ƚw
                            ClickSuspended();
                            // ���榸��
                            actionCount++;
                            // �i�ױ�
                            labProcess.Text = string.Format("{0} / {1}", actionCount, totalCount);
                            progressBar.Value = actionCount / totalCount;
                            if (progressBar.Value == 1)
                            {
                                success = true;
                                MessageBox.Show("�I���u�Ƚw�Ƶ{�v����");
                            }
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
                MessageBox.Show("�o�Ϳ��~, �������í��s����.");
            }
        }

        /// <summary>
        /// ����Ƚw�@��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActionStartOne_Click(object sender, EventArgs e)
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
                    try
                    {
                        var totalProduct = driver.FindElement(By.CssSelector("input[name='btnNotDow']"));
                        // ���o�ݭn����u�Ƚw�v���`�ƶq
                        if (totalProduct != null)
                            totalCount = 1;
                    }
                    catch
                    {
                        totalCount = 0;
                    }
                    if (totalCount > 0)
                    {
                        // �w�g���檺�ƶq
                        int actionCount = 1;
                        // �I���Ƚw
                        ClickSuspended();
                        // �i�ױ�
                        labProcess.Text = string.Format("{0} / {1}", actionCount, totalCount);
                        progressBar.Value = actionCount / totalCount;
                        MessageBox.Show("�I���u�Ƚw�@���v����");
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
                MessageBox.Show("�o�Ϳ��~, �������í��s����.");
            }
        }

        /// <summary>
        /// �I���Ƚw
        /// </summary>
        protected void ClickSuspended()
        {
            try
            {
                if (driver != null)
                {
                    int step = 0;
                    while (step < 2)
                    {
                        switch (step)
                        {
                            case 0:
                                IWebElement _btnNotDow = driver.FindElement(By.CssSelector("input[name='btnNotDow']"));
                                if (_btnNotDow != null)
                                {
                                    _btnNotDow.Click();
                                    step = 1;
                                }
                                break;
                            case 1:
                                IWebElement _alertCloseBtn = driver.FindElement(By.Id("alertCloseBtn"));
                                if (_alertCloseBtn != null)
                                {
                                    _alertCloseBtn.Click();
                                    step = 2;
                                }
                                break;
                            default:
                                step = 2;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("�I���Ƚw�X�{���~, �нT�{���`���D�G" + ex.ToString());
            }
        }

        private void btn_GetCoupon_Click(object sender, EventArgs e)
        {
            if (driver != null)
            {
                int step = 1;
                while (step != 4)
                {
                    try
                    {
                        switch (step)
                        {
                            case 1:
                                // ��3999�e2000
                                IWebElement _promoActivity0_2 = driver.FindElement(By.Id("promoActivity0_2"));
                                _promoActivity0_2.Click();
                                IWebElement _promoActivity0_2_swal2_confirm_swal2_styled = driver.FindElement(By.CssSelector(".swal2-confirm.swal2-styled"));
                                IWebElement _swal2_title = driver.FindElement(By.Id("swal2-title"));
                                if (_swal2_title.Text.Contains("�B��") == false)
                                {
                                    step = 2;
                                }
                                _promoActivity0_2_swal2_confirm_swal2_styled.Click();
                                break;
                            case 2:
                                // ��1990�e1000
                                IWebElement _promoActivity0_1 = driver.FindElement(By.Id("promoActivity0_1"));
                                _promoActivity0_1.Click();
                                IWebElement _promoActivity0_1_swal2_confirm_swal2_styled = driver.FindElement(By.CssSelector(".swal2-confirm.swal2-styled"));
                                IWebElement _swal2_title_1 = driver.FindElement(By.Id("swal2-title"));
                                if (_swal2_title_1.Text.Contains("�B��") == false)
                                {
                                    step = 3;
                                }
                                _promoActivity0_1_swal2_confirm_swal2_styled.Click();
                                break;
                            case 3:
                                // ��990�e500
                                IWebElement _promoActivity0_0 = driver.FindElement(By.Id("promoActivity0_0"));
                                _promoActivity0_0.Click();
                                IWebElement _promoActivity0_0_swal2_confirm_swal2_styled = driver.FindElement(By.CssSelector(".swal2-confirm.swal2-styled"));
                                IWebElement _swal2_title_2 = driver.FindElement(By.Id("swal2-title"));
                                if (_swal2_title_2.Text.Contains("�B��") == false)
                                {
                                    step = 4;
                                }
                                _promoActivity0_0_swal2_confirm_swal2_styled.Click();
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("�I���Ƚw�X�{���~, �нT�{���`���D�G" + ex.ToString());
                    }
                }
            }
        }
    }
}