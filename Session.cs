using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Phần_mềm_thi_trắc_nghiệm
{
    public static class Session
    {
        public static UserAccount CurrentUser { get; set; }
    }
}
