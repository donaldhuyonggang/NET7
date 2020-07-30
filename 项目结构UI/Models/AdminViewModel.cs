using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace 项目结构UI.Models
{
    /// <summary>
    /// 视图模型类(为了验证)。
    /// </summary>
    public class AdminViewModel
    {
        [Required(ErrorMessage = "账号不可以为空")]
      //  [StringLength(10,ErrorMessage ="长度在6~10之间",MinimumLength =6)] 
        public string LoginUID { get; set; }

        [Required(ErrorMessage = "密码不可以为空")]
        public string LoginPWD { get; set; }
    }
}