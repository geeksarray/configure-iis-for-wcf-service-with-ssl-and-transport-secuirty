# Configure IIS for WCF service with SSL and transport security

This article will help you to configure IIS for WCF service with SSL and achieve WCF Transport security. It uses a WCF service, create a SSL certificate using IIS Server Certificates with WCF service hosted in IIS.

In Windows Communication Foundation Transport security is dependent on the binding and transport being used. It requires an SSL certificate to be registered with IIS. For a production environment, you must obtain the certificate from third party certificate issuer like Verisign. In Transport Security server and clients are configured with X.509 certificates to allow verification of other parties. 

## Application

1. **[WCF Service](https://github.com/geeksarray/configure-iis-for-wcf-service-with-ssl-and-transport-secuirty/tree/master/IISHost/NorthwindServices)** - WCF service implemented for IProduct service contract.

1. **[WCF Service client](https://github.com/geeksarray/configure-iis-for-wcf-service-with-ssl-and-transport-secuirty/tree/master/IISHost/NorthwindApp)** - WCF service client consume Product Service from Northwind WCF Service.


Below picture shows required configuration on IIS

![WCF Service Transport level security](http://dotnetmentors.com/Images/IIS-Edit-Bindings.png)

For detailed steps on visit [Configure IIS for WCF service with SSL and transport security](https://geeksarray.com/blog/configure-iis-for-wcf-service-with-ssl-and-transport-secuirty)
