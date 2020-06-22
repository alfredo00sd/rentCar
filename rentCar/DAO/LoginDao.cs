using rentCar.DTO.user;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentCar.DAO.user
{
    class LoginDao : DBConnection
    {
        //public UserDTO ValidateLoggin(String userCard, String userClave)
        //{
        //    UserDTO user = new UserDTO();

        //    try
        //    {
        //        Conexion.Open();

        //        SqlCommand command = new SqlCommand("select e.employee_card as userCard, u.user_password as userPass, r.rol_key as rol from employees e, users u, roles r where e.employee_card = @userCard and u.user_password = @userClave and u.user_status = 1 and r.rol_id = u.rol_id;", Conexion);
        //        command.Parameters.AddWithValue("@userCard", userCard);
        //        command.Parameters.AddWithValue("@userClave", userClave);//Remember to encode the password

        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {

        //                user.username = reader.GetString(0);
        //                user.password = reader.GetString(1);
        //                user.rolKey = reader.GetString(2);

        //                //MessageBox.Show("User : " + user + ", Pass : " + pass + " and rol : " + rol);
        //            }

        //            return user;
        //        }
        //        else { return null; }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //    finally { Conexion.Close(); }
        //}

    }
}
