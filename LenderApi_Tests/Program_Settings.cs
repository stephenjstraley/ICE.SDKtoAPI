using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        public static void SetDev()
        {
            _secret = "1iBrMYdinPn!0c&Xn1g02Xz8*vG&!g6oUtGSlPwkOOkq3$loiie6FfxxyFVqb20D";
            _apiClientId = "mugdegt";
            _userName = "straley_api";
            _instanceId = "TEbe11147603";
            _password = "Welcome@123";
            _loanNumber = "0550210504";
            _loanGuid = string.Empty;
            _fromFolder = "My Pipeline";
            _env = "Dev";
            _dtc = true;
        }

        public static void SetUpgradeQa()
        {
            _secret = "wkB^K68yPeokOH0GBC9WF#FJgwJQl!OgxIEPeUdjXsOIdyK*osNstoDIICvmSure";
            _apiClientId = "xt5e7s6";
            _userName = "straley_api";
            _instanceId = "TEbe11147089";
            _password = "Bowling900!";
            _loanNumber = "051008912";
            _loanGuid = "d25b20a3-7ffd-4c39-b02f-a6959bc14e1d";
            _fromFolder = "My Pipeline";
            _env = "Upgrade QA";
            _dtc = true;
        }

        public static void SetQa()
        {
            _instanceId = "TEbe11166795";
            _apiClientId = "auftnup";
            _userName = "svc_sweeps";
            _password = "q@mHU!99MmxqWEa#";
            _secret = "2XxHcknzAcpgfOHig&$Uu4!ieUB63qwQmRx2y^#mQ8GM0aRU7m1tGfTVftnOODNA";
            _loanNumber = "0550469290"; // "0550460620"; // "0550180660"; // "0550459747"; // "0550180660"; // "0550210504";  // "0550383244"
            _loanGuid = string.Empty;
            _fromFolder = "My Pipeline";
            _env = "QA";
            _dtc = true;
        }

        public static void SetUat()
        {
            _secret = "kpl6qaW7acc1yFqIfH7k@N!Va23FwZLo8IE7u3tUbfHL0vXuy6%Sx13y40&V40pH";
            _apiClientId = "kvu7tdh";
            _userName = "svc_sweeps";
            _instanceId = "TEbe11142756";
            _password = "q@mHU!99MmxqWEa#";
            _loanNumber = "0806153284"; // "0800101151";
            _loanGuid = string.Empty;
            _fromFolder = "My Pipeline";
            _env = "UAT";
            _dtc = true;
        }

        public static void SetProd()
        {
            _secret = "4jSAC8AmggDlcBlW6KLyW!Ldfv6xdcjWFdsCV@knZBq@abZA5grd$B1FHKou3Twg";
            _apiClientId = "l62zikr";
            _userName = "svc_sweeps";
            _instanceId = "BE11090546";
            _password = "T!a!L1#2!5XAkVAt";
            _loanNumber = "0806153284"; // "0800101151";
            _loanGuid = string.Empty;
            _fromFolder = "My Pipeline";
            _env = "UAT";
            _dtc = true;
        }
        public static void SetDevTPO()
        {
            _secret = "kcznO7Yf2nF0cwlmv5c9#3a&pmjTjcqt6GwwIKlx03n!qDqPCuchpWd!tJVbC4YJ";
            _apiClientId = "zttjegw";
            _userName = "svc_sweeps";
            _instanceId = "TEbe11213790";
            _password = "q@mHU!99MmxqWEa#";
            _loanNumber = string.Empty;
            _loanGuid = string.Empty;
            _fromFolder = "Cancel-Decline Wholesale";
            _dtc = false;
            _env = "TPO Dev";
        }
        public static void SetQaTPO()
        {
            _instanceId = "TEbe11168543";
            _apiClientId = "5hijop6";
            _userName = "svc_sweeps";
            _password = "q@mHU!99MmxqWEa#";
            _secret = "hAVi#00MJCysW8!FxLhC4tkaz5*g9v!q&!F8KXS&rbeGvB@9vxfSMuS#6YIAW4pI";
            _loanNumber = string.Empty;
            _loanGuid = string.Empty;
            _fromFolder = "Cancel-Decline Wholesale";
            _dtc = false;
            _env = "TPO QA";
        }
        public static void SetUatTPO()
        {
            _secret = "W28gt^2aETc$V7BM$8Q3bjCkxw#7ARvxf&@JNE8jEWyw&^LbkYY0UF4mdUKbS4pU";
            _apiClientId = "30nhez4";
            _userName = "svc_sweeps";
            _instanceId = "TEbe11168545";
            _password = "q@mHU!99MmxqWEa#";
            _loanNumber = "1800001529";
            _loanGuid = string.Empty;
            _fromFolder = "Cancel-Decline Wholesale";
            _dtc = false;
            _env = "TPO UAT";
        }
    }
}
