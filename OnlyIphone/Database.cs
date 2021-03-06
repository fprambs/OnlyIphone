﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OnlyIphone
{
    class Database
    {
        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public static User getUser(string username)
        {
            User user = new User();
            MySqlConnection connection = Connection.getConnection();
            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT username, password FROM user WHERE username='{0}'", username), connection);
            MySqlDataReader reader  = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.Username = reader.GetString(0);
                user.Password = reader.GetString(1);
            }
            connection.Close();
            return user;

        }

        public static int addProvider(Provider prv)
        {
            int retorno = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into provider (name, phone, email, address, city) values ('{0}','{1}','{2}', '{3}', '{4}')",
                prv.Name, prv.Phone, prv.Email, prv.Address, prv.City), Connection.getConnection());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("No se pudo agregar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }

        public static List<Provider> listProviders()
        {

            List<Provider> _list = new List<Provider>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT name, phone, email, address, city FROM provider "), Connection.getConnection());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Provider Prv = new Provider();

                Prv.Name = _reader.GetString(0);
                Prv.Phone = _reader.GetInt32(1);
                Prv.Email = _reader.GetString(2);
                Prv.Address = _reader.GetString(3);
                Prv.City = _reader.GetString(4);


                _list.Add(Prv);
            }

            return _list;
        }

        public static int addType(Type type)
        {
            int retorno = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into type (name) values ('{0}')", type.Name), Connection.getConnection());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("No se pudo agregar el tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return retorno;
            }
        }
    }
}
