using Bao_Hanh;
using DevExpress.XtraEditors;
using FRT_Pharma.Form.Dialog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public class Util
{
    public static string connectionstring = "";
    public static SqlConnection conn = new SqlConnection(@"Data Source =DEV_DATNM11\SQLEXPRESS; Initial Catalog = QuanLyBaoHanh; Integrated Security = True");

    public static bool connectSQL()
    {
        try
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static void disconnectSQL()
    {
        try
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        catch (Exception) { }
    }

    public static int RunSql(string query)
    {
        connectSQL();
        SqlCommand cmd = new SqlCommand(query, conn);
        try
        {
            int a = cmd.ExecuteNonQuery();
            return a;

        }
        catch (Exception ex) { return -1; }
        finally
        {
            disconnectSQL();
        }

    }
    public static DataTable GetData(string sql)

    {
        try
        {
            connectSQL();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        catch (Exception ex)
        {
            Util.f_Notify("Lỗi: " + ex.Message, false);
            return null;
        }
        finally
        {
            disconnectSQL();
        }

    }
    public static DataTable GetData(string sql, SqlParameter[] param)
    {
        try
        {
            connectSQL();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        catch (Exception ex) { return null; }
        finally
        {
            disconnectSQL();
        }

    }
    public static DataTable GetStoredData(string sql)
    {
        try
        {
            connectSQL();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        catch (Exception ex) { return null; }
        finally
        {
            disconnectSQL();
        }

    }
    public static DataTable GetStoredData(string sql, SqlParameter[] param)
    {
        try
        {
            connectSQL();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        catch (Exception ex) { return null; }
        finally
        {
            disconnectSQL();
        }

    }
    //public static Main s_FormMain = new Main();
    public static XtraForm s_FormMain = new XtraForm();
    public static void f_Notify(string a_Text, bool a_IsSuccess, bool a_IsWarrning = false)
    {
        Color clor = new Color();
        if (a_IsWarrning)
        {
            clor = Color.FromArgb(230, 175, 75);
        }
        else
        {
            if (a_IsSuccess)
            {
                clor = Color.FromArgb(67, 160, 71);
            }
            else
            {
                clor = Color.FromArgb(239, 83, 80);
            }
        }

        Flyout_Form form = new Flyout_Form(clor, a_Text);
        form.Location = s_FormMain.Location;
        form.Width = s_FormMain.Width;
        form.Show(s_FormMain);
    }



}
