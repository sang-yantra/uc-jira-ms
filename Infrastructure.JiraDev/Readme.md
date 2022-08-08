### Credentials


{
  "ConnectionStrings": {
    "Default": "Server=zm42x1ncy7o5.ap-south-2.psdb.cloud;Database=jira;user=391g0us8vf1v;password=pscale_pw_LZlrwzlieUaoL8QoOuL11Q85bEZ5Od4t0asb2EXVwF4;SslMode=VerifyFull;"
  },
}

public void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<MySqlConnection>(_ => new MySqlConnection(Configuration["ConnectionStrings:Default"]));
}


-------
node js

DATABASE_URL='mysql://391g0us8vf1v:pscale_pw_LZlrwzlieUaoL8QoOuL11Q85bEZ5Od4t0asb2EXVwF4@zm42x1ncy7o5.ap-south-2.psdb.cloud/jira?ssl={"rejectUnauthorized":true}'

require('dotenv').config();
const mysql = require('mysql2');
const connection = mysql.createConnection(process.env.DATABASE_URL);
console.log('Connected to PlanetScale!');
connection.end();

-------
prisma

DATABASE_URL='mysql://391g0us8vf1v:pscale_pw_LZlrwzlieUaoL8QoOuL11Q85bEZ5Od4t0asb2EXVwF4@zm42x1ncy7o5.ap-south-2.psdb.cloud/jira?sslaccept=strict'


---admin
new account

server=zm42x1ncy7o5.ap-south-2.psdb.cloud;user=xt4oq63z4cty;database=jira;port=3306;password=pscale_pw_3A7PCTleUgUoPs_AAKqnJrCNTuzEo5mBcyaK9DtMDNQ;SslMode=VerifyFull

---node 

const mysql = require('mysql2');
const connection = mysql.createConnection("mysql://xt4oq63z4cty:pscale_pw_3A7PCTleUgUoPs_AAKqnJrCNTuzEo5mBcyaK9DtMDNQ@zm42x1ncy7o5.ap-south-2.psdb.cloud/jira?ssl={"rejectUnauthorized":true}")
---prism

datasource db {
  provider = "mysql"
  url = "mysql://xt4oq63z4cty:pscale_pw_3A7PCTleUgUoPs_AAKqnJrCNTuzEo5mBcyaK9DtMDNQ@zm42x1ncy7o5.ap-south-2.psdb.cloud/jira?sslaccept=strict"
}


Scaffold-DbContext "server=zm42x1ncy7o5.ap-south-2.psdb.cloud;user=xt4oq63z4cty;database=jira;port=3306;password=pscale_pw_3A7PCTleUgUoPs_AAKqnJrCNTuzEo5mBcyaK9DtMDNQ;SslMode=VerifyFull" Pomelo.EntityFrameworkCore.MySql -ContextDir MySql_Entities\DbContext -Context MysqlJiraContext -OutputDir MySql_Entities\Models
