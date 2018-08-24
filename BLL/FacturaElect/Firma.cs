using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using FirmaXadesNet;
using FirmaXadesNet.Crypto;
using FirmaXadesNet.Signature.Parameters;

namespace BLL
{
    public class Firma
    {
        public void FirmaXML_Xades(string pathXML, string thumbprintCertificado)
        {
            try
            {
                X509Certificate2 cert = GetCertificateByThumbprint(thumbprintCertificado);
                // 'Ejemplo de un valor Thumbprint: C2E8D9DA714C98ED14B88ECBC4C3E5F3BD64F125
                // 'Si no se quiere leer el certificado del repositorio, se puede cargar el certificado directamente
                //Dim cert As X509Certificate2 = New X509Certificate2("rutaArchivoCertificado", "clave")

                XadesService xadesService = new XadesService();
                SignatureParameters parametros = new SignatureParameters();

                parametros.SignaturePolicyInfo = new SignaturePolicyInfo();
                parametros.SignaturePolicyInfo.PolicyIdentifier = "https://tribunet.hacienda.go.cr/docs/esquemas/2016/v4.2/ResolucionComprobantesElectronicosDGT-R-48-2016_4.2.pdf";
                //La propiedad PolicyHash es la misma para todos, es un cálculo en base al archivo pdf indicado en PolicyIdentifier
                parametros.SignaturePolicyInfo.PolicyHash = "Ohixl6upD6av8N7pEvDABhEL6hM=";
                parametros.SignaturePackaging = SignaturePackaging.ENVELOPED;
                parametros.DataFormat = new DataFormat();
                parametros.Signer = new FirmaXadesNet.Crypto.Signer(cert);

                FileStream fs = new FileStream((pathXML+".xml"), FileMode.Open);
                FirmaXadesNet.Signature.SignatureDocument docFirmado = xadesService.Sign(fs, parametros);
                docFirmado.Save((pathXML+"firmado.xml"));

                // El documento se firma con el dll FirmaXadesNet
                // Esta libreria fue creada por Departamento de Nuevas Tecnologias - Direccion General de Urbanismo Ayuntamiento de Cartagena
                // 'Fuente original se puede descargar en administracionelectronica.gob.es/ctt/firmaxadesnet
                // 'La libreria se modifico levemente para que pueda funcionar para Costa Rica.

                fs.Close();
                docFirmado = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public X509Certificate2 GetCertificateByThumbprint(string thumbprintCertificado)
        {
            X509Certificate2 cert = null;
            X509Store store = new X509Store("My", StoreLocation.CurrentUser);
            try
            {
                store.Open((OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly));
                X509Certificate2Collection CertCol = store.Certificates;
                foreach (X509Certificate2 c in CertCol)
                {
                    if ((c.Thumbprint == thumbprintCertificado))
                    {
                        cert = c;
                        break;
                    }
                }

                if ((cert == null))
                {
                    store = new X509Store("My", StoreLocation.LocalMachine);
                    CertCol = store.Certificates;
                    foreach (X509Certificate2 c in CertCol)
                    {
                        if ((c.Thumbprint == thumbprintCertificado))
                        {
                            cert = c;
                            break;
                        }
                    }
                }

                if ((cert == null))
                {
                    throw new CryptographicException("El certificado no se encuentra registrado");
                }
            }
            finally
            {
                store.Close();
            }
            return cert;
        }

    }
}
