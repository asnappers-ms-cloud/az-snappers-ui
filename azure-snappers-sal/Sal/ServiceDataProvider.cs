using azure_snappers_sal.Controller;
using azure_snappers_sal.Model;
using Newtonsoft.Json;
using System;

using System.Net.Http;
using System.Net.Http.Headers;


namespace azure_snappers_sal.Sal
{
    class ServiceDataProvider : IDataProvider

    {
        public HouseDetails GetDetails()
        {
            var details = makeRequest();
            return details;
        }

        //private HouseDetails makeRequest()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://az2-property-service.azurewebsites.net/");
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        //HTTP GET
        //        var responseTask = client.GetAsync("Housedetails/1");
        //        responseTask.Wait();

        //        var result = responseTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {

        //            var readTask = result.Content.ReadAsAsync<HouseDetails>();
        //            readTask.Wait();

        //            var students = readTask.Result;

        //            //foreach (var student in students)
        //            //{
        //            //    //Console.WriteLine(student./*Name*/);
        //            //}
        //            return students;
        //        }
        //        else
        //        {
        //            return new HouseDetails();
        //        }
        //    }
        //}

        private static HouseDetails makeRequest()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://az2-property-service.azurewebsites.net/");
                var response = client.GetAsync("Housedetails/1");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var contentStream = result.Content.ReadAsStringAsync();
                    contentStream.Wait();

                    var str = contentStream.Result;
                    var detail = JsonConvert.DeserializeObject<HouseDetails>(str);
                    return detail;
                }
                else
                {
                    return new HouseDetails();
                }
            }
        }
    }

   
}
