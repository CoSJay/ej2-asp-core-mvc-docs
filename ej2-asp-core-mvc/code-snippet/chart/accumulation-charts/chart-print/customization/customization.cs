public ActionResult Index()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {

                new PieChartData { x = "Chrome", y = 61.3, text = "Chrome: 61.3%"},
                new PieChartData { x = "Safari", y = 24.6, text = "Safari: 24.6%"},
                new PieChartData { x = "Edge", y = 5.0, text = "Edge: 5.0%"},
                new PieChartData { x = "Samsung Internet", y = 2.7, text = "Samsung Internet: 2.7%"},
                new PieChartData { x = "Firefox", y = 2.6, text = "Firefox: 2.6%"},
                new PieChartData { x = "Others", y = 3.6, text = "Others: 3.6%"}
            };
            ViewBag.dataSource = chartData;
            return View();
        }
         public class PieChartData
        {
            public string x;
            public double y;
            public string text;
        }

