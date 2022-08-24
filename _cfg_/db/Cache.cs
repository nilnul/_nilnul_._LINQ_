using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul_._LINQ_._cfg_.db
{
	/*Hi all. I have a question... How can I use sqlCachedependency from my class library??? I tried to add 

<system.web>
<caching>
 <sqlCacheDependency enabled="true" pollTime="1000" >
<databases>
 <add  name="myDB"
connectionStringName="myConnectionString" />
 </databases>
 </sqlCacheDependency>
 </caching> 
 </system.web> 

in my app.config

but when I try to test the library project it gives me error stating that it can't find database "myDB". 

Error appears here : System.Web.Caching.SqlCacheDependency myTableDependency = new System.Web.Caching.SqlCacheDependency("myDB", "myTable");
 Test method myTest.myCacheTest.UyeHesapToplamTest threw exception:  System.Web.HttpException: cant't find database 'myDB' in configuration..
 
But from the web application everything works fine. Please HELP!!!
*/
	class Cache
	{
	}
}
