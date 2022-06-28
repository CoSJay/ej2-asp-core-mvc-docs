public IActionResult Index()
        {
            string[] color1 = { "#F9D422" };
            string[] color2 = { "#F28F3F" };
            string[] color3 = { "#E94F53" };
            List<RangeColorMappingData> chartData = new List<RangeColorMappingData>
            {
                  new RangeColorMappingData { x= "Jan", y= 6.96},
                  new RangeColorMappingData { x= "Feb", y= 8.9},
                  new RangeColorMappingData { x= "Mar", y= 12},
                  new RangeColorMappingData { x= "Apr", y= 17.5},
                  new RangeColorMappingData { x= "May", y= 22.1},
                  new RangeColorMappingData { x= "June", y= 25},
                  new RangeColorMappingData { x= "July", y= 29.4},
                  new RangeColorMappingData { x= "Aug", y= 29.6},
                  new RangeColorMappingData { x= "Sep", y= 25.8},
                  new RangeColorMappingData { x= "Oct", y= 21.1},
                  new RangeColorMappingData { x= "Nov", y= 15.5},
                  new RangeColorMappingData { x= "Dec", y= 9.9}
            };
            ViewBag.dataSource = chartData;
            ViewBag.color1 = color1;
            ViewBag.color2 = color2;
            ViewBag.color3 = color3;
            return View();
        }
        public class RangeColorMappingData
        {
            public string x;
            public double y;
        }