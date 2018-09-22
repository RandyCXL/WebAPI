using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    /// <summary>
    /// 测试api控制器
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// 通过id获取值
        /// </summary>
        /// <param name="person">主键</param>
        /// <returns></returns>
        public string MyValue(Person person)
        {
            return "陈晓俐";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string MyValued(string name)
        {
            return "陈晓俐";
        }

        /// <summary>
        /// 通过id获取值
        /// </summary>
        /// <param name="name">主键</param>
        /// <returns></returns>
        public string YouValue(int name)
        {
            return "陈晓俐";
        }

        /// <summary>
        /// GET api/values
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// GET api/values/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public string Get(int id)
        {
            return "value";
        }

        ///// <summary>
        ///// POST api/values
        ///// </summary>
        ///// <param name="value">值</param>

        //public void Post([FromBody]string value)
        //{
        //}

        ///// <summary>
        ///// PUT api/values/5
        ///// </summary>
        ///// <param name="id">主键</param>
        ///// <param name="value">值</param>

        //public void Put(int id, [FromBody]string value)
        //{
        //}

        ///// <summary>
        ///// DELETE api/values/5
        ///// </summary>
        ///// <param name="id">主键</param>

        //public void Delete(int id)
        //{
        //}
    }
}
