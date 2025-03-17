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
            // 初始化
            InitializeComponent();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        /// <summary>
        /// 開啟瀏覽器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenWeb_Click(object sender, EventArgs e)
        {
            try
            {
                // 開啟控制台視窗
                AllocConsole();
                Console.WriteLine("開啟瀏覽器, 請稍後...");
                // 開啟瀏覽器, 並跳轉至設定頁面
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(driverService);
                string url = "https://scm.momoshop.com.tw/manage/login.jsp";
                driver.Navigate().GoToUrl(url);
                Console.WriteLine("開啟瀏覽器完成");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// 執行暫緩排程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActionStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (driver != null)
                {
                    // 設定進度條從0開啟
                    progressBar.Value = 0;
                    // 總數量
                    int totalCount = 0;
                    // 取得所有需要點擊暫緩的商品
                    try
                    {
                        var totalProducts = driver.FindElements(By.CssSelector("input[name='btnNotDow']"));
                        // 取得需要執行「暫緩」的總數量
                        if (totalProducts != null)
                            totalCount = totalProducts.Count();
                    }
                    catch
                    {
                        totalCount = 0;
                    }
                    if (totalCount > 0)
                    {
                        // 執行狀態
                        bool success = false;
                        // 已經執行的數量
                        int actionCount = 0;
                        while (success == false)
                        {
                            // 點擊暫緩
                            ClickSuspended();
                            // 執行次數
                            actionCount++;
                            // 進度條
                            labProcess.Text = string.Format("{0} / {1}", actionCount, totalCount);
                            progressBar.Value = actionCount / totalCount;
                            if (progressBar.Value == 1)
                            {
                                success = true;
                                MessageBox.Show("點擊「暫緩排程」完成");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("無任何需要執行「暫緩」的商品");
                    }
                }
                else
                {
                    MessageBox.Show("請先開啟瀏覽器");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("發生錯誤, 請關閉並重新執行.");
            }
        }

        /// <summary>
        /// 執行暫緩一筆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActionStartOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (driver != null)
                {
                    // 設定進度條從0開啟
                    progressBar.Value = 0;
                    // 總數量
                    int totalCount = 0;
                    // 取得所有需要點擊暫緩的商品
                    try
                    {
                        var totalProduct = driver.FindElement(By.CssSelector("input[name='btnNotDow']"));
                        // 取得需要執行「暫緩」的總數量
                        if (totalProduct != null)
                            totalCount = 1;
                    }
                    catch
                    {
                        totalCount = 0;
                    }
                    if (totalCount > 0)
                    {
                        // 已經執行的數量
                        int actionCount = 1;
                        // 點擊暫緩
                        ClickSuspended();
                        // 進度條
                        labProcess.Text = string.Format("{0} / {1}", actionCount, totalCount);
                        progressBar.Value = actionCount / totalCount;
                        MessageBox.Show("點擊「暫緩一筆」完成");
                    }
                    else
                    {
                        MessageBox.Show("無任何需要執行「暫緩」的商品");
                    }
                }
                else
                {
                    MessageBox.Show("請先開啟瀏覽器");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("發生錯誤, 請關閉並重新執行.");
            }
        }

        /// <summary>
        /// 點擊暫緩
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
                Console.WriteLine("點擊暫緩出現錯誤, 請確認異常問題：" + ex.ToString());
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
                                // 滿3999送2000
                                IWebElement _promoActivity0_2 = driver.FindElement(By.Id("promoActivity0_2"));
                                _promoActivity0_2.Click();
                                IWebElement _promoActivity0_2_swal2_confirm_swal2_styled = driver.FindElement(By.CssSelector(".swal2-confirm.swal2-styled"));
                                IWebElement _swal2_title = driver.FindElement(By.Id("swal2-title"));
                                if (_swal2_title.Text.Contains("額滿") == false)
                                {
                                    step = 2;
                                }
                                _promoActivity0_2_swal2_confirm_swal2_styled.Click();
                                break;
                            case 2:
                                // 滿1990送1000
                                IWebElement _promoActivity0_1 = driver.FindElement(By.Id("promoActivity0_1"));
                                _promoActivity0_1.Click();
                                IWebElement _promoActivity0_1_swal2_confirm_swal2_styled = driver.FindElement(By.CssSelector(".swal2-confirm.swal2-styled"));
                                IWebElement _swal2_title_1 = driver.FindElement(By.Id("swal2-title"));
                                if (_swal2_title_1.Text.Contains("額滿") == false)
                                {
                                    step = 3;
                                }
                                _promoActivity0_1_swal2_confirm_swal2_styled.Click();
                                break;
                            case 3:
                                // 滿990送500
                                IWebElement _promoActivity0_0 = driver.FindElement(By.Id("promoActivity0_0"));
                                _promoActivity0_0.Click();
                                IWebElement _promoActivity0_0_swal2_confirm_swal2_styled = driver.FindElement(By.CssSelector(".swal2-confirm.swal2-styled"));
                                IWebElement _swal2_title_2 = driver.FindElement(By.Id("swal2-title"));
                                if (_swal2_title_2.Text.Contains("額滿") == false)
                                {
                                    step = 4;
                                }
                                _promoActivity0_0_swal2_confirm_swal2_styled.Click();
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("點擊暫緩出現錯誤, 請確認異常問題：" + ex.ToString());
                    }
                }
            }
        }
    }
}