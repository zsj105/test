using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Model 的摘要说明
/// </summary>
public class Model
{
    public class User
    {

        public string Name { get; set; }
        public string PassWord { get; set; }
        public string Mz { get; set; }
        public string State { get; set; }
        public DateTime Datatime { get; set; }
    }
    public class Yz
    {
        public string Car { get; set; }
        public string State { get; set; }
        public string Sex { get; set; }
        public string Name { get; set; }
        public string Dh { get; set; }
        public string Dizhi { get; set; }
        public string CW { get; set; }

    }
    public class Car
    {
        public string Cp { get; set; }
        public string Qy { get; set; }
        public string Weizhi { get; set; }
        public string State { get; set; }
        public DateTime Itime { get; set; }
        public DateTime Otime { get; set; }
    }
    public class Jl
    {
        public string Cp { get; set; }
        public string Qy { get; set; }
        public string Weizhi { get; set; }
        public string Pay { get; set; }
        public DateTime Itime { get; set; }
        public DateTime Otime { get; set; }
    }
}