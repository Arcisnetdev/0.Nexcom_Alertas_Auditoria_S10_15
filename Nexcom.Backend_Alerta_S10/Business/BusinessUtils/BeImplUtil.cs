using Nexcom.Backend_Alerta_S10.Business.BusinessData;

namespace Nexcom.Backend_Alerta_S10.Business.BusinessUtils
{


    public sealed class BeImplUtil
    {
        private static BeImplDataInterface _dataInterface;
        public const string IV = "AUPSJB123456";
        public const string Key = "123456AUPSJB";

        public static Nexcom.Backend_Alerta_S10.Business.BusinessData.BeImplData BeImplData
        {
            get
            {
                if (_dataInterface == null)
                {
                    _dataInterface = new Nexcom.Backend_Alerta_S10.Business.BusinessData.BeImplData();
                }
                return (Nexcom.Backend_Alerta_S10.Business.BusinessData.BeImplData)_dataInterface;
            }
        }
    }
}
