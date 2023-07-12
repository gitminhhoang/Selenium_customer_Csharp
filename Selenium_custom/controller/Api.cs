using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chilkat;
using Newtonsoft.Json;
using Selenium_custom.model;
using static Selenium_custom.model.Update_profile_proxy;
using static Selenium_custom.model.UpdateProxy;

namespace Selenium_custom.controller
{
    public class Api
    {
        public String OpenProfile(string uid)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "GET";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");
                Chilkat.HttpResponse httpResponse = http.QuickGetObj("http://localhost:5555/openProfile?uuid=" + uid);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String CloseProfile(string uid)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "GET";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");
                Chilkat.HttpResponse httpResponse = http.QuickGetObj("http://localhost:5555/closeProfile?uuid=" + uid);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String CheckProfileOpen(string uid)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "GET";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");
                Chilkat.HttpResponse httpResponse = http.QuickGetObj("http://localhost:5555/authorize?uuid=" + uid);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetListProfile(int page = 1, int limit = 10)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "GET";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                Chilkat.HttpResponse httpResponse = http.QuickGetObj("http://localhost:5555/profileList?page=" + page + "&limit=" + limit);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetListConfigDefault(int page = 1,int limit = 10)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "GET";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                Chilkat.HttpResponse httpResponse = http.QuickGetObj("http://localhost:5555/get-list-config-default?page="+page+ "&limit="+limit);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetListStatus()
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "GET";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                Chilkat.HttpResponse httpResponse = http.QuickGetObj("http://localhost:5555/get-list-status");
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetListTag()
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "GET";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                Chilkat.HttpResponse httpResponse = http.QuickGetObj("http://localhost:5555/get-list-tag");
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetProfileByUid(string uid)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "GET";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                Chilkat.HttpResponse httpResponse = http.QuickGetObj("http://localhost:5555/browser/get-profile-by-uuid?uuid="+ uid);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string CreateProfileByDefault(string uid)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "POST";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");
                
                Chilkat.HttpResponse httpResponse = http.PostJson("http://localhost:5555/create-profile-by-default", "{\"config_id\":"+uid+ "}");
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string CreateProfileCustomize(Body_Customize _body)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "POST";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                Chilkat.HttpResponse httpResponse = http.PostJson("http://localhost:5555/create-profile-custom", JsonConvert.SerializeObject(_body));
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public string UpdateNote(Update_note _body)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "PUT";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                string httpResponse = http.PutText("http://localhost:5555/browser/update-note", JsonConvert.SerializeObject(_body), "utf-8", "application/json", false, false);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                return httpResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string UpdateName(Update_name _body)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "PUT";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                string httpResponse = http.PutText("http://localhost:5555/browser/update-name",JsonConvert.SerializeObject(_body),"utf-8", "application/json", false,false);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                return httpResponse;
                //return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Sync_Tag(Sync_tag _body)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "PUT";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                string httpResponse = http.PutText("http://localhost:5555/sync-tags", JsonConvert.SerializeObject(_body), "utf-8", "application/json", false, false);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                return httpResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Change_Status(Change_status _body)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "PUT";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                string httpResponse = http.PutText("http://localhost:5555/change-status", JsonConvert.SerializeObject(_body), "utf-8", "application/json", false, false);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                return httpResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Delete_Profile(Delete_profile _body)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "DELETE";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                Chilkat.HttpResponse httpResponse = http.PText("DELETE", "http://localhost:5555/delete-profile",JsonConvert.SerializeObject(_body), "utf-8", "application/json", false, false);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Update_Proxy(Body_Update_Proxy _body)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "PUT";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                string httpResponse = http.PutText("http://localhost:5555/change-status", JsonConvert.SerializeObject(_body), "utf-8", "application/json", false, false);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                return httpResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Update_Profile_Proxy(Body_update_profile_proxy _body)
        {
            try
            {

                Http http = new Http();
                Chilkat.HttpRequest httpRequest = new Chilkat.HttpRequest();
                httpRequest.HttpVerb = "PUT";

                
                http.SetRequestHeader("Connection", "keep-alive");
                http.SetRequestHeader("Accept", "*/*");
                http.SetRequestHeader("Content-Type", "application/json");

                string httpResponse = http.PutText("http://localhost:5555/change-status", JsonConvert.SerializeObject(_body), "utf-8", "application/json", false, false);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                return httpResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
