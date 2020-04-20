/* //web.config内容如下 */
<appSettings>
  <add key="webpages:Version"              value="3.0.0.0" />
  <add key="webpages:Enabled"              value="false" />
  <add key="ClientValidationEnabled"       value="true" />
  <add key="UnobtrusiveJavaScriptEnabled"  value="true" />

  <add key="testKey"                       value="any value"/>
  <add key="key1"                          value="abc"/>
</appSettings>

<connectionStrings>
  <add name="connStr1"      connectionString="template content"/>
  <add name="connStr2"      connectionString="template content"/>
  <add name="connStr3"      connectionString="template content"/>
  <add name="connStr4"      connectionString="template content"/>
  <add name="connStr5"      connectionString="template content"/>
  <add name="key1"          connectionString="abcd"/>
</connectionStrings>

//web.release.config设置如下

<appSettings >
  <add key="testKey" value="test" xdt:Transform="Replace" xdt:Locator="Match(key)"/>
</appSettings>

<connectionStrings xdt:Transform="Replace">
  <add name="connStr1"          connectionString="release1"/>
  <add name="connStr2"          connectionString="release2"/>
  <add name="connStr3"          connectionString="release3"/>
  <add name="connStr4"          connectionString="release4"/>
  <add name="connStr5"          connectionString="release5" />

  <add name="some_string_else"  connectionString="release else"/>
  <add name="key1"              connectionString="release1213"/>
</connectionStrings>
//publish 生成的 web.config

<appSettings>
  <add key="webpages:Version" value="3.0.0.0" />
  <add key="webpages:Enabled" value="false" />
  <add key="ClientValidationEnabled" value="true" />
  <add key="UnobtrusiveJavaScriptEnabled" value="true" />
  <add key="testKey" value="TestConfig test value" />
  <add key="key1" value="abc" />
</appSettings>
<connectionStrings>
  <add name="connStr1" connectionString="release1" />
  <add name="connStr2" connectionString="release2" />
  <add name="connStr3" connectionString="release3" />
  <add name="connStr4" connectionString="release4" />
  <add name="connStr5" connectionString="release5" />
  <add name="some_string_else" connectionString="release else" />
  <add name="key1" connectionString="release1213" />
</connectionStrings>

