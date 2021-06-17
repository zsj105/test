using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// DAL 的摘要说明
/// </summary>
public class DAL
{
    public class User
    {
        public static bool Zhuce(Model.User user)
        {
            bool res = false;
            string sql = string.Format("insert into user1(name,password,datatime,mz,state)values('{0}','{1}','{2}','{3}','{4}')", user.Name, user.PassWord, DateTime.Now, user.Mz, user.State);
            int row = Sql.NonQuery(sql);
            if (row > 0)
            {
                res = true;
            }
            return res;
        }
        public static bool Dengru(Model.User use)
        {
            bool res = false;
            string sql = string.Format("select name,password from user1 where name='{0}' and  password='{1}' and state='{2}'", use.Name, use.PassWord, "超级管理员");
            SqlDataReader dr = Sql.Reader(sql);
            if (dr.HasRows)
            {
                res = true;
            }
            return res;
        }
        public static bool Dengru1(Model.User use)
        {
            bool res = false;
            string sql = string.Format("select name,password from user1 where name='{0}' and  password='{1}' and state='{2}'", use.Name, use.PassWord, "管理员");
            SqlDataReader dr = Sql.Reader(sql);
            if (dr.HasRows)
            {
                res = true;
            }
            return res;
        }
        public static SqlDataReader Chaxun()
        {
            string sql = string.Format("select * from user1 ");
            return Sql.Reader(sql);

        }
        public static SqlDataReader Chaxun1()
        {
            string sql = string.Format("select * from user1 where state='{0}'", "普通管理员");
            return Sql.Reader(sql);





        }
        public static void Shanchu(string id)
        {
            string sql = string.Format("delete from user1 where id='{0}'", id);
            Sql.NonQuery(sql);


        }
        public static int Xiugai(Model.User use, string id)
        {
            string sql = string.Format("update user1 set name='{0}',password='{1}',mz='{2}'where id='{3}'",
use.Name, use.PassWord, use.Mz, id);
            return Sql.NonQuery(sql);
        }
        public static SqlDataReader Pd(string name)
        {
            string sql = string.Format("select name from user1 where name='{0}'", name);
            return Sql.Reader(sql);
        }
        public static void Xianshi(string id, Model.User use)
        {
            string sql = string.Format("select * from user1 where id='{0}'", id);
            DataSet ds = Sql.Daset(sql);
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                use.Name = ds.Tables[0].Rows[i]["name"].ToString();
                use.PassWord = ds.Tables[0].Rows[i]["password"].ToString();
                use.Datatime = DateTime.Parse(ds.Tables[0].Rows[i]["datatime"].ToString());
                use.Mz= ds.Tables[0].Rows[i]["mz"].ToString();
                use.State = ds.Tables[0].Rows[i]["state"].ToString();

            }


        }
    }

    public class Yz
    {
        public static int Dengji1(Model.Yz yz)
        {

            string sql = string.Format("insert into Yz(cp,name,sex,cw,dianhua,dizhi)values('{0}','{1}','{2}','{3}','{4}','{5}')", yz.Car, yz.Name, yz.Sex, yz.CW, yz.Dh, yz.Dizhi);
            return Sql.NonQuery(sql);
        }
        public static SqlDataReader Pd(string car)
        {
            string sql = string.Format("select cp from yz where cp='{0}'", car);
            return Sql.Reader(sql);
        }
        public static void Shanchu(string id)
        {
            string sql = string.Format("delete from yz where id='{0}'", id);
            Sql.NonQuery(sql);
        }
        public static SqlDataReader Chaxun()
        {
            string sql = string.Format("select * from yz ");
            return Sql.Reader(sql);

        }
        public static int Xiugai(Model.Yz yz, string id)
        {
            string sql = string.Format("update yz set cp='{0}',name='{1}',sex='{2}',cw='{3}',dianhua='{4}',dizhi='{5}'where id='{6}'", yz.Car, yz.Name, yz.Sex, yz.CW, yz.Dh, yz.Dizhi, id);
            return Sql.NonQuery(sql);
        }
    }
    public class Car
    {
        public static SqlDataReader Pd(Model.Car car)
        {
            string sql = string.Format("select qy,weizhi from car1 where qy='{0}' and weizhi='{1}'", car.Qy, car.Weizhi);
            return Sql.Reader(sql);
        }
        public static int Tianjia(Model.Car car)
        {
            string sql = string.Format("insert into car1(qy,weizhi)values('{0}','{1}')", car.Qy, car.Weizhi);
            return Sql.NonQuery(sql);
        }
        public static void Shanchu(string id)
        {
            string sql = string.Format("delete from car where id='{0}'", id);
            Sql.NonQuery(sql);
        }
        public static SqlDataReader Chaxun()
        {
            string sql = string.Format("select * from car ");
            return Sql.Reader(sql);
        }
        public static DataSet Pd1(Model.Car car)
        {
            string sql = string.Format("select state from car where qy='{0}'and weizhi='{1}' ", car.Qy, car.Weizhi);
            return Sql.Daset(sql);
        }
        public static void Up(Model.Car car)
        {
            string sql = string.Format("update car set state='{0}', itime='{1}',cp='{2}'  where qy='{3}'and weizhi='{4}'", 1, DateTime.Now, car.Cp, car.Qy, car.Weizhi);
            Sql.NonQuery(sql);
        }

        public static int Ls(Model.Jl jl)
        {
            string sql = string.Format("insert into jilu (cp,qy,weizhi,itime,otime,pay)values('{0}','{1}','{2}','{3}','{4}','{5}')", jl.Cp, jl.Qy, jl.Weizhi, jl.Itime, DateTime.Now, jl.Pay);
            return Sql.NonQuery(sql);
        }
    }
}