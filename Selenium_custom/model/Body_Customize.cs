using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_custom.model
{
    public class Body_Customize
    {
        public string os { get; set; }
        public string version { get; set; }
        public string userAgent { get; set; }
        public string canvas { get; set; }
        public string webGLImage { get; set; }
        public string audioContext { get; set; }
        public string webGLMetadata { get; set; }
        public string clientRectsEnable { get; set; }
        public string webGLVendor { get; set; }
        public string webGLMetadataRenderer { get; set; }
        public string StartURL { get; set; }
        public string languages { get; set; }
        public string resolution { get; set; }

    }

    public class Response_create_customize
    {
        public string type { get; set; }
        public string title { get; set; }
        public Content content { get; set; }
    }

    public class Content
    {
        public string uuid { get; set; }
        public Config config { get; set; }
        public string directory { get; set; }
        public string file_name { get; set; }
        public bool can_be_running { get; set; }
        public string proxy { get; set; }
        public DateTime created_at { get; set; }
        public string created_at_diff { get; set; }
        public int id { get; set; }
        public string folder_id { get; set; }
        public object check_open { get; set; }
        public string name { get; set; }
        public int version { get; set; }
        public string browser_type { get; set; }
        public string os { get; set; }
        public string note { get; set; }
        public object last_open { get; set; }
        public object last_open_diff { get; set; }
        public string transfer { get; set; }
        public string source_version { get; set; }
        public bool shares_role { get; set; }
        public string shared_uuid { get; set; }
        public object status { get; set; }
        public int status_chil { get; set; }
        public object[] tags { get; set; }
        public object status_id { get; set; }
        public object[] option { get; set; }
        public string disk { get; set; }
    }

    public class Config
    {
        public string name { get; set; }
        public string version { get; set; }
        public string os { get; set; }
        public string browser { get; set; }
        public Fingerprint fingerprint { get; set; }
        public string browser_type { get; set; }
        public string[] fonts { get; set; }
    }

    public class Fingerprint
    {
        public Navigator navigator { get; set; }
        public Screen screen { get; set; }
        public Webgl2 webgl2 { get; set; }
        public Webgl webgl { get; set; }
        public Languages languages { get; set; }
        public Fonts fonts { get; set; }
        public Mediadevices mediaDevices { get; set; }
        public string webRtcLocalIps { get; set; }
        public Ports ports { get; set; }
        public string browser_type { get; set; }
        public Timezone timezone { get; set; }
        public Webrtc webrtc { get; set; }
        public Geolocation geoLocation { get; set; }
        public Proxy proxy { get; set; }
        public object storage { get; set; }
        public string StartURL { get; set; }
        public object Uid { get; set; }
        public int canvasCntPixels { get; set; }
        public object CanvasModel { get; set; }
        public float canvasNoise { get; set; }
        public Plugins plugins { get; set; }
        public object exxtension { get; set; }
        public Macaddress macAddress { get; set; }
        public Computername computerName { get; set; }
    }

    public class Navigator
    {
        public string userAgent { get; set; }
        public string osVersion { get; set; }
        public string browserVersion { get; set; }
        public string browser { get; set; }
        public int hardwareConcurrency { get; set; }
        public string platform { get; set; }
        public int maxTouchPoints { get; set; }
        public int deviceMemory { get; set; }
        public string doNotTrack { get; set; }
        public object oscpu { get; set; }
        public object buildID { get; set; }
        public string browserVersionName { get; set; }
        public string device { get; set; }
        public string sourceVersion { get; set; }
    }

    public class Screen
    {
        public int width { get; set; }
        public int height { get; set; }
        public int pixelRatio { get; set; }
    }

    public class Webgl2
    {
        public string canvas { get; set; }
        public Audiocontext audioContext { get; set; }
        public bool WebGLImage { get; set; }
        public bool WebGLMeta { get; set; }
        public bool clientRectsEnable { get; set; }
        public float ClientRectsNoice { get; set; }
        public float WebglNoiseValue { get; set; }
        public string unmaskedVendor { get; set; }
        public string unmaskedRenderer { get; set; }
        public string[] extensions { get; set; }
        public Supportedfunction[] supportedFunctions { get; set; }
        public Param[] _params { get; set; }
        public bool antialiasing { get; set; }
    }

    public class Audiocontext
    {
        public bool enable { get; set; }
        public float noiseValue { get; set; }
    }

    public class Supportedfunction
    {
        public string name { get; set; }
        public bool supported { get; set; }
    }

    public class Param
    {
        public string name { get; set; }
        public object value { get; set; }
    }

    public class Webgl
    {
        public string unmaskedVendor { get; set; }
        public string unmaskedRenderer { get; set; }
    }

    public class Languages
    {
        public string acceptLanguage { get; set; }
    }

    public class Fonts
    {
        public bool isEnabled { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        public string name { get; set; }
        public int required { get; set; }
        public int isChecked { get; set; }
    }

    public class Mediadevices
    {
        public bool enableMasking { get; set; }
        public bool enable { get; set; }
        public int videoInputs { get; set; }
        public int audioInputs { get; set; }
        public int audioOutputs { get; set; }
        public string uid { get; set; }
    }

    public class Ports
    {
        public bool isEnabled { get; set; }
        public string portsToProtect { get; set; }
    }

    public class Timezone
    {
        public bool isProxy { get; set; }
        public string nameTimezone { get; set; }
    }

    public class Webrtc
    {
        public bool fill_based_on_ip { get; set; }
        public string localIps { get; set; }
        public bool local_ip_masking { get; set; }
        public string mode { get; set; }
        public bool publicIP { get; set; }
        public bool public_ip { get; set; }
    }

    public class Geolocation
    {
        public bool isProxy { get; set; }
        public string mode { get; set; }
        public int accuracy { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class Proxy
    {
        public bool IsProxy { get; set; }
        public string ProxyHost { get; set; }
        public string ProxyPort { get; set; }
        public int ProxyType { get; set; }
        public string ProxyUsername { get; set; }
        public string ProxyPassword { get; set; }
        public bool IsDNS { get; set; }
        public object IpDNS { get; set; }
        public string Geolocation { get; set; }
        public string Webrtc { get; set; }
        public string TimeZone { get; set; }
        public bool checkBeforeStart { get; set; }
    }

    public class Plugins
    {
        public bool all_enable { get; set; }
        public bool flash_enable { get; set; }
    }

    public class Macaddress
    {
        public bool isEnabled { get; set; }
        public string value { get; set; }
    }

    public class Computername
    {
        public bool isEnabled { get; set; }
        public string value { get; set; }
    }

}
