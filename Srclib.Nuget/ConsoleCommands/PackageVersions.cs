using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Srclib.Nuget
{
    public class PackageVersions
    {
        private Dictionary<string, string> versions;

        public PackageVersions()
        {
            versions = new Dictionary<string, string>(400);
            versions["microsoft.web.infrastructure"] = "1.0.0";
            versions["entityframework"] = "6.1.3";
            versions["newtonsoft.json"] = "8.0.2";
            versions["microsoft.aspnet.webapi.client"] = "5.2.3";
            versions["microsoft.aspnet.webpages"] = "3.2.3";
            versions["microsoft.aspnet.mvc"] = "5.2.3";
            versions["microsoft.aspnet.razor"] = "3.2.3";
            versions["owin"] = "1.0.0";
            versions["microsoft.aspnet.webapi.core"] = "5.2.3";
            versions["microsoft.aspnet.web.optimization"] = "1.1.3";
            versions["microsoft.aspnet.webapi.webhost"] = "5.2.3";
            versions["microsoft.owin"] = "3.0.1";
            versions["microsoft.aspnet.webapi"] = "5.2.3";
            versions["system.collections"] = "4.0.10";
            versions["system.resources.resourcemanager"] = "4.0.0";
            versions["system.runtime"] = "4.0.20";
            versions["microsoft.owin.host.systemweb"] = "3.0.1";
            versions["antlr"] = "3.4.1.9004";
            versions["microsoft.owin.security"] = "3.0.1";
            versions["system.threading"] = "4.0.10";
            versions["system.reflection.primitives"] = "4.0.0";
            versions["system.threading.tasks"] = "4.0.10";
            versions["system.io"] = "4.0.10";
            versions["system.private.uri"] = "4.0.0";
            versions["webgrease"] = "1.5.2";
            versions["system.reflection.extensions"] = "4.0.0";
            versions["system.text.encoding"] = "4.0.10";
            versions["system.io.filesystem.primitives"] = "4.0.0";
            versions["system.reflection"] = "4.0.0";
            versions["system.text.encoding.extensions"] = "4.0.10";
            versions["system.globalization"] = "4.0.0";
            versions["system.diagnostics.tracing"] = "4.0.20";
            versions["system.diagnostics.debug"] = "4.0.0";
            versions["system.runtime.extensions"] = "4.0.10";
            versions["system.io.filesystem"] = "4.0.0";
            versions["modernizr"] = "2.6.2";
            versions["system.runtime.handles"] = "4.0.0";
            versions["microsoft.bcl"] = "1.1.10";
            versions["system.linq.expressions"] = "4.0.10";
            versions["microsoft.owin.security.oauth"] = "3.0.1";
            versions["system.runtime.interopservices"] = "4.0.20";
            versions["system.threading.overlapped"] = "4.0.0";
            versions["microsoft.net.http"] = "2.2.29";
            versions["jquery"] = "1.10.2";
            versions["system.reflection.typeextensions"] = "4.0.0";
            versions["system.globalization.calendars"] = "4.0.0";
            versions["microsoft.aspnet.identity.core"] = "2.2.1";
            versions["microsoft.owin.security.cookies"] = "3.0.1";
            versions["system.objectmodel"] = "4.0.10";
            versions["microsoft.bcl.build"] = "1.0.21";
            versions["system.reflection.emit.ilgeneration"] = "4.0.0";
            versions["system.reflection.emit"] = "4.0.0";
            versions["microsoft.jquery.unobtrusive.validation"] = "3.2.3";
            versions["system.linq"] = "4.0.0";
            versions["microsoft.win32.primitives"] = "4.0.0";
            versions["system.reflection.emit.lightweight"] = "4.0.0";
            versions["bootstrap"] = "3.0.0";
            versions["system.collections.nongeneric"] = "4.0.0";
            versions["microsoft.aspnet.identity.owin"] = "2.2.1";
            versions["respond"] = "1.2.0";
            versions["system.runtime.numerics"] = "4.0.0";
            versions["moq"] = "4.2.1510.2205";
            versions["jquery.validation"] = "1.11.1";
            versions["microsoft.net.compilers"] = "1.0.0";
            versions["xunit.abstractions"] = "2.0.0";
            versions["system.collections.immutable"] = "1.1.37";
            versions["system.diagnostics.tools"] = "4.0.0";
            versions["system.text.regularexpressions"] = "4.0.10";
            versions["commonservicelocator"] = "1.3.0";
            versions["microsoft.bcl.async"] = "1.0.168";
            versions["microsoft.aspnet.identity.entityframework"] = "2.2.1";
            versions["nunit"] = "2.6.4";
            versions["xunit.extensibility.execution"] = "2.1.0";
            versions["system.security.principal"] = "4.0.0";
            versions["xunit.core"] = "2.1.0";
            versions["microsoft.aspnet.webapi.owin"] = "5.2.3";
            versions["xunit.extensibility.core"] = "2.1.0";
            versions["microsoft.codedom.providers.dotnetcompilerplatform"] = "1.0.0";
            versions["microsoft.azure.keyvault.core"] = "1.0.0";
            versions["microsoft.data.odata"] = "5.6.4";
            versions["system.collections.concurrent"] = "4.0.10";
            versions["microsoft.data.edm"] = "5.6.4";
            versions["system.spatial"] = "5.6.4";
            versions["system.componentmodel.primitives"] = "4.0.0";
            versions["xunit.assert"] = "2.1.0";
            versions["xunit"] = "2.1.0";
            versions["system.componentmodel"] = "4.0.0";
            versions["system.xml.readerwriter"] = "4.0.10";
            versions["log4net"] = "2.0.5";
            versions["system.security.claims"] = "4.0.0";
            versions["microsoft.aspnet.cors"] = "5.2.3";
            versions["microsoft.data.services.client"] = "5.6.4";
            versions["system.net.primitives"] = "4.0.10";
            versions["microsoft.owin.security.google"] = "3.0.1";
            versions["microsoft.owin.security.facebook"] = "3.0.1";
            versions["microsoft.applicationinsights"] = "1.2.3";
            versions["system.net.http"] = "4.0.0";
            versions["microsoft.owin.security.twitter"] = "3.0.1";
            versions["microsoft.owin.security.microsoftaccount"] = "3.0.1";
            versions["system.appcontext"] = "4.0.0";
            versions["system.private.networking"] = "4.0.0";
            versions["microsoft.applicationinsights.windowsserver.telemetrychannel"] = "1.2.3";
            versions["microsoft.applicationinsights.dependencycollector"] = "1.2.3";
            versions["microsoft.applicationinsights.perfcountercollector"] = "1.2.3";
            versions["microsoft.applicationinsights.windowsserver"] = "1.2.3";
            versions["microsoft.applicationinsights.web"] = "1.2.3";
            versions["autofac"] = "3.5.2";
            versions["system.componentmodel.eventbasedasync"] = "4.0.10";
            versions["microsoft.aspnet.webapi.cors"] = "5.2.3";
            versions["system.globalization.extensions"] = "4.0.0";
            versions["system.threading.timer"] = "4.0.0";
            versions["system.io.compression"] = "4.0.0";
            versions["windowsazure.storage"] = "6.2.0";
            versions["htmlagilitypack"] = "1.4.9";
            versions["microsoft.windowsazure.configurationmanager"] = "3.1.0";
            versions["nuget.commandline"] = "3.3.0";
            versions["system.reflection.metadata"] = "1.1.0";
            versions["microsoft.applicationinsights.agent.intercept"] = "1.2.0";
            versions["system.data.common"] = "4.0.0";
            versions["microsoft.aspnet.webapi.helppage"] = "5.2.3";
            versions["sharpziplib"] = "0.86.0";
            versions["restsharp"] = "105.2.3";
            versions["system.identitymodel.tokens.jwt"] = "4.0.2.206221351";
            versions["system.threading.threadpool"] = "4.0.10-beta-23409";
            versions["microsoft.aspnet.signalr.core"] = "2.2.0";
            versions["system.security.cryptography.primitives"] = "4.0.0-beta-23409";
            versions["system.threading.thread"] = "4.0.0-beta-23409";
            versions["system.xml.xmldocument"] = "4.0.0";
            versions["unity"] = "4.0.1";
            versions["system.threading.tasks.parallel"] = "4.0.0";
            versions["system.diagnostics.tracesource"] = "4.0.0-beta-23409";
            versions["system.collections.specialized"] = "4.0.0";
            versions["system.io.compression.clrcompression-x64"] = "4.0.0";
            versions["system.linq.queryable"] = "4.0.0";
            versions["system.io.compression.clrcompression-x86"] = "4.0.0";
            versions["microsoft.csharp"] = "4.0.0";
            versions["jquery.ui.combined"] = "1.11.4";
            versions["system.console"] = "4.0.0-beta-23409";
            versions["xunit.runner.utility"] = "2.1.0";
            versions["system.dynamic.runtime"] = "4.0.10";
            versions["microsoft.applicationinsights.javascript"] = "0.15.0-build58334";
            versions["microsoft.extensions.dependencyinjection.abstractions"] = "1.0.0-rc1-final";
            versions["nlog"] = "4.2.3";
            versions["microsoft.aspnet.signalr.js"] = "2.2.0";
            versions["microsoft.extensions.logging.abstractions"] = "1.0.0-rc1-final";
            versions["system.diagnostics.contracts"] = "4.0.0";
            versions["microsoft.owin.cors"] = "3.0.1";
            versions["system.io.unmanagedmemorystream"] = "4.0.0";
            versions["microsoft.extensions.logging"] = "1.0.0-rc1-final";
            versions["microsoft.framework.dependencyinjection.abstractions"] = "1.0.0-beta8";
            versions["system.security.cryptography.algorithms"] = "4.0.0-beta-23409";
            versions["ninject"] = "3.2.2";
            versions["microsoft.aspnet.signalr.systemweb"] = "2.2.0";
            versions["microsoft.framework.configuration"] = "1.0.0-beta8";
            versions["system.componentmodel.annotations"] = "4.0.10";
            versions["microsoft.framework.configuration.abstractions"] = "1.0.0-beta8";
            versions["system.security.cryptography.encoding"] = "4.0.0-beta-23409";
            versions["system.security.cryptography.x509certificates"] = "4.0.0-beta-23409";
            versions["system.xml.xdocument"] = "4.0.10";
            versions["microsoft.extensions.primitives"] = "1.0.0-rc1-final";
            versions["microsoft.framework.logging.abstractions"] = "1.0.0-beta8";
            versions["microsoft.extensions.configuration.abstractions"] = "1.0.0-rc1-final";
            versions["webactivatorex"] = "2.0.6";
            versions["microsoft.extensions.platformabstractions"] = "1.0.0-rc1-final";
            versions["microsoft.framework.dependencyinjection"] = "1.0.0-beta8";
            versions["microsoft.codeanalysis.analyzers"] = "1.0.0";
            versions["microsoft.extensions.configuration"] = "1.0.0-rc1-final";
            versions["nuget.build"] = "2.8.6";
            versions["microsoft.framework.primitives"] = "1.0.0-beta8";
            versions["microsoft.framework.logging"] = "1.0.0-beta8";
            versions["microsoft.framework.optionsmodel"] = "1.0.0-beta8";
            versions["xunit.runner.console"] = "2.1.0";
            versions["microsoft.framework.configuration.binder"] = "1.0.0-beta8";
            versions["microsoft.aspnet.signalr"] = "2.2.0";
            versions["microsoft.framework.configuration.json"] = "1.0.0-beta8";
            versions["system.linq.parallel"] = "4.0.0";
            versions["microsoft.dnx.runtime.abstractions"] = "1.0.0-beta8";
            versions["microsoft.framework.configuration.fileextensions"] = "1.0.0-beta8";
            versions["system.io.filesystem.watcher"] = "4.0.0-beta-23409";
            versions["microsoft.netcore.targets"] = "1.0.0";
            versions["microsoft.framework.webencoders.core"] = "1.0.0-beta8";
            versions["microsoft.aspnet.http.abstractions"] = "1.0.0-beta8";
            versions["microsoft.aspnet.http.features"] = "1.0.0-beta8";
            versions["microsoft.aspnet.fileproviders.abstractions"] = "1.0.0-beta8";
            versions["microsoft.aspnet.hosting.abstractions"] = "1.0.0-beta8";
            versions["system.componentmodel.typeconverter"] = "4.0.1-beta-23409";
            versions["microsoft.net.http.headers"] = "1.0.0-beta8";
            versions["microsoft.aspnet.http.extensions"] = "1.0.0-beta8";
            versions["microsoft.dnx.compilation.abstractions"] = "1.0.0-beta8";
            versions["system.diagnostics.tracing.telemetry"] = "4.0.0-beta-23409";
            versions["microsoft.aspnet.webutilities"] = "1.0.0-beta8";
            versions["microsoft.aspnet.fileproviders.physical"] = "1.0.0-beta8";
            versions["system.net.websockets"] = "4.0.0-beta-23409";
            versions["microsoft.extensions.dependencyinjection"] = "1.0.0-rc1-final";
            versions["microsoft.framework.configuration.environmentvariables"] = "1.0.0-beta8";
            versions["system.net.networkinformation"] = "4.0.0";
            versions["microsoft.aspnet.http"] = "1.0.0-beta8";
            versions["microsoft.framework.configuration.commandline"] = "1.0.0-beta8";
            versions["microsoft.aspnet.hosting"] = "1.0.0-beta8";
            versions["microsoft.aspnet.hosting.server.abstractions"] = "1.0.0-beta8";
            versions["microsoft.framework.webencoders"] = "1.0.0-beta8";
            versions["microsoft.netcore.platforms"] = "1.0.0";
            versions["microsoft.aspnet.server.kestrel"] = "1.0.0-beta8";
            versions["elmah.corelibrary"] = "1.2.2";
            versions["system.numerics.vectors"] = "4.1.1-beta-23409";
            versions["system.diagnostics.stacktrace"] = "4.0.1-beta-23409";
            versions["runtime.unix.system.diagnostics.tracesource"] = "4.0.0-beta-23409";
            versions["microsoft.owin.hosting"] = "3.0.1";
            versions["microsoft.aspnet.staticfiles"] = "1.0.0-beta8";
            versions["runtime.unix.system.security.cryptography.encoding"] = "4.0.0-beta-23409";
            versions["runtime.unix.system.security.cryptography.x509certificates"] = "4.0.0-beta-23409";
            versions["system.security.cryptography.openssl"] = "4.0.0-beta-23409";
            versions["runtime.unix.system.console"] = "4.0.0-beta-23409";
            versions["automapper"] = "4.1.1";
            versions["runtime.unix.system.private.uri"] = "4.0.1-beta-23409";
            versions["runtime.unix.system.threading"] = "4.0.11-beta-23409";
            versions["microsoft.extensions.configuration.binder"] = "1.0.0-rc1-final";
            versions["runtime.linux.system.runtime.extensions"] = "4.0.11-beta-23409";
            versions["runtime.unix.system.diagnostics.debug"] = "4.0.11-beta-23409";
            versions["runtime.linux.system.io.filesystem"] = "4.0.1-beta-23409";
            versions["system.diagnostics.diagnosticsource"] = "4.0.0-beta-23516";
            versions["runtime.linux.system.security.cryptography.algorithms"] = "4.0.0-beta-23409";
            versions["runtime.unix.system.globalization.extensions"] = "4.0.1-beta-23409";
            versions["runtime.unix.system.net.primitives"] = "4.0.11-beta-23409";
            versions["runtime.linux.system.io.filesystem.watcher"] = "4.0.0-beta-23409";
            versions["microsoft.extensions.optionsmodel"] = "1.0.0-rc1-final";
            versions["xunit.runner.visualstudio"] = "2.1.0";
            versions["microsoft.netcore.targets.universalwindowsplatform"] = "5.0.0";
            versions["system.xml.xmlserializer"] = "4.0.10";
            versions["microsoft.extensions.webencoders.core"] = "1.0.0-rc1-final";
            versions["dapper"] = "1.42.0";
            versions["system.runtime.interopservices.windowsruntime"] = "4.0.0";
            versions["system.net.webheadercollection"] = "4.0.0";
            versions["nunittestadapter"] = "2.0.0";
            versions["rx-core"] = "2.2.5";
            versions["dnx-coreclr-linux-x64"] = "1.0.0-beta8";
            versions["system.reflection.dispatchproxy"] = "4.0.0";
            versions["rx-interfaces"] = "2.2.5";
            versions["microsoft.netcore.runtime.coreclr-x64"] = "1.0.0";
            versions["system.text.encoding.codepages"] = "4.0.0";
            versions["rx-linq"] = "2.2.5";
            versions["microsoft.netcore.runtime.coreclr-x86"] = "1.0.0";
            versions["microsoft.jquery.unobtrusive.ajax"] = "3.2.3";
            versions["microsoft.extensions.configuration.json"] = "1.0.0-rc1-final";
            versions["microsoft.extensions.caching.abstractions"] = "1.0.0-rc1-final";
            versions["microsoft.extensions.caching.memory"] = "1.0.0-rc1-final";
            versions["castle.core"] = "3.3.3";
            versions["nuget.galleryuptime"] = "1.0.0";
            versions["microsoft.extensions.configuration.fileextensions"] = "1.0.0-rc1-final";
            versions["microsoft.visualbasic"] = "10.0.0";
            versions["xunit.runner.reporters"] = "2.1.0";
            versions["system.runtime.serialization.json"] = "4.0.0";
            versions["microsoft.owin.security.jwt"] = "3.0.1";
            versions["system.runtime.windowsruntime"] = "4.0.10";
            versions["system.security.cryptography.cng"] = "4.0.0-beta-23516";
            versions["microsoft.extensions.configuration.environmentvariables"] = "1.0.0-rc1-final";
            versions["ix-async"] = "1.2.5";
            versions["microsoft.extensions.configuration.commandline"] = "1.0.0-rc1-final";
            versions["microsoft.extensions.webencoders"] = "1.0.0-rc1-final";
            versions["microsoft.netcore.runtime.coreclr-arm"] = "1.0.0";
            versions["autofac.webapi2"] = "3.4.0";
            versions["microsoft.codeanalysis.csharp"] = "1.1.0-rc1-20151109-01";
            versions["system.runtime.serialization.primitives"] = "4.0.10";
            versions["system.threading.tasks.dataflow"] = "4.5.25";
            versions["microsoft.codeanalysis.common"] = "1.1.0-rc1-20151109-01";
            versions["bouncycastle"] = "1.7.0";
            versions["rx-platformservices"] = "2.2.5";
            versions["documentformat.openxml"] = "2.5.0";
            versions["microsoft.owin.host.httplistener"] = "3.0.1";
            versions["enterpriselibrary.transientfaulthandling"] = "6.0.1304";
            versions["system.io.compression.zipfile"] = "4.0.0";
            versions["microsoft.aspnet.html.abstractions"] = "1.0.0-rc1-final";
            versions["microsoft.dnx.compilation.csharp.abstractions"] = "1.0.0-rc1-final";
            versions["system.private.datacontractserialization"] = "4.0.0";
            versions["microsoft.aspnet.cryptography.internal"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.razor.runtime"] = "4.0.0-rc1-final";
            versions["microsoft.aspnet.dataprotection"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.dataprotection.abstractions"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.diagnostics.abstractions"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.authorization"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.mvc.core"] = "6.0.0-rc1-final";
            versions["microsoft.extensions.memorypool"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.mvc.abstractions"] = "6.0.0-rc1-final";
            versions["microsoft.aspnet.routing"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.iisplatformhandler"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.jsonpatch"] = "1.0.0-rc1-final";
            versions["system.runtime.serialization.xml"] = "4.0.10";
            versions["microsoft.extensions.localization.abstractions"] = "1.0.0-rc1-final";
            versions["microsoft.extensions.localization"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.antiforgery"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.pageexecutioninstrumentation.interfaces"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.mvc.razor.host"] = "6.0.0-rc1-final";
            versions["microsoft.extensions.globalization.cultureinfocache"] = "1.0.0-rc1-final";
            versions["microsoft.aspnet.localization"] = "1.0.0-rc1-final";
            versions["sendgrid.smtpapi"] = "1.3.1";
            versions["microsoft.aspnet.mvc.formatters.json"] = "6.0.0-rc1-final";
            versions["microsoft.netcore.portable.compatibility"] = "1.0.0";
            versions["microsoft.aspnet.mvc.viewfeatures"] = "6.0.0-rc1-final";
            versions["microsoft.aspnet.mvc.dataannotations"] = "6.0.0-rc1-final";
            versions["microsoft.aspnet.mvc.razor"] = "6.0.0-rc1-final";
            versions["microsoft.aspnet.mvc.apiexplorer"] = "6.0.0-rc1-final";
            versions["microsoft.aspnet.mvc.cors"] = "6.0.0-rc1-final";
            versions["rx-main"] = "2.2.5";
            versions["microsoft.aspnet.mvc.localization"] = "6.0.0-rc1-final";
            versions["microsoft.aspnet.razor.runtime.precompilation"] = "4.0.0-rc1-final";
            versions["microsoft.netcore.runtime"] = "1.0.0";
            versions["microsoft.dnx.compilation.csharp.common"] = "1.0.0-rc1-final";
        }

        public string GetVersion(string name)
        {
            if (versions.ContainsKey(name))
            {
                return versions[name];
            }
            else
            {
                return null;
            }
        }
    }
}

