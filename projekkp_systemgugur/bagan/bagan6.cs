﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace projekkp_systemgugur.bagan
{
    public partial class bagan6 : Form
    {
        private SqlCommand cmd;

        private SqlDataAdapter da;
        koneksi konn = new koneksi();
        public bagan6()
        {
            InitializeComponent();
        }
         public bagan6(string terima) :
            this()
        {
            label1.Text=terima;
        }

        private void bagan6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        void diniA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajai()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaiA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasai1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasai2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }






        void remajaa6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajab6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajac6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajad6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajae6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        void remajaf6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajag6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajah6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajai6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        void dinia6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinib6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinic6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinid6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinie6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        void dinif6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinig6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinih6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinii6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }



        void dewasaa6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasab6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasac6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasad6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasae6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        void dewasaf6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasag6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasah6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasai6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }



        void praremajaa6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajab6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajac6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajad6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajae6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        void praremajaf6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajag6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajah6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajai6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }





        void dewasah1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasah2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasag1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasag2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasaf1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasaf2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasae1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasae2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasad1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasad2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasac1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasac2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasab1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasab2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasaa1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasaa2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajah()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaAh()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajag()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaAg()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaf()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajafA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajae()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaAe()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaea()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajada()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajadA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaca()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajacA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaba()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajabA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaa()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajai()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaiA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajah()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaAh()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajag()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaAg()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajafs()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajafA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajae()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaAe()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaea()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajada()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajadaA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaca()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajacA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaa3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajab3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajac3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajad3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajae3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaf3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajag3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajah3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajai3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaba()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajabA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajaa()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void diniiA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAai()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinihA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAha()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinigA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAga()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAf()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAaf()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAe()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAea()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAd()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAda()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinicA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAc()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAa()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAbb()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAb()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1);
                        label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAa3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAc3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAd3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAe3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAf3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAg3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAh3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAi3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaa3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajab3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajac3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajad3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajae3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaf3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajag3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajah3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajai3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasaa3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasab3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasac3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasad3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasae3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasaf3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasag3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasah3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasai3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaa4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajab4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajac4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajad4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajae4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaf4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajag4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajah4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajai4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaa5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajab5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajac5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajad5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajae5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaf5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajag5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajah5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajai5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaa5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajab5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajac5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajad5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajae5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaf5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajag5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajah5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajai5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasaa5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasab5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasac5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasad5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasae5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasaf5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasag5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasah5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasai5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinia5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinib5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinic5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinid5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinie5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinif5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinig5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinih5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinii5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasaa4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasab4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasac4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasad4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasae4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasaf4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasag4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasah4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasai4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinia4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinib4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinic4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinid4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinie4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinif4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinig4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinih4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinii4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajaa4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajab4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajac4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajad4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajae4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        void remajaf4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajag4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajah4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajai4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        void diniAb3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void masingmasingbagan()
        {
            if (label1.Text == "Usia Dini Kelas A")
            {
                diniA(); dinia5();
                diniAa3(); dinia4();
                diniAa(); dinia6();
            }
            else if (label1.Text == "Usia Dini Kelas B")
            {
                diniAb(); dinib5();
                diniAb(); dinib4();
                diniAbb(); dinib6();
            }
            else if (label1.Text == "Usia Dini Kelas C")
            {
                dinicA(); dinic5();
                diniAc(); dinic6();
                diniAc3(); dinic4();
            }
            else if (label1.Text == "Usia Dini Kelas D")
            {
                diniAd(); dinid5();
                diniAda(); dinid4();
                diniAd3(); dinid6();
            }
            else if (label1.Text == "Usia Dini Kelas E")
            {
                diniAe(); dinie5();
                diniAea(); dinie4();
                diniAe3(); dinie6();
            }
            else if (label1.Text == "Usia Dini Kelas F")
            {
                diniAaf(); dinif5();
                diniAf(); dinif4();
                diniAf3(); dinif6();
            }
            else if (label1.Text == "Usia Dini Kelas G")
            {
                diniAga(); dinig4();
                dinigA(); dinig5();
                diniAg3(); dinig6();
            }
            else if (label1.Text == "Usia Dini Kelas H")
            {
                diniAha(); dinih4();
                dinihA(); dinih5();
                diniAh3(); dinih6();
            }
            else if (label1.Text == "Usia Dini Kelas I")
            {
                diniiA(); dinii4();
                diniAai(); dinii5();
                diniAi3(); dinii6();
            }
            else if (label1.Text == "Pra Remaja Kelas A")
            {
                praremajaa(); praremajaa6();
                praremajaa3();
                praremajaa5();
                praremajaa4();
                praremajaA();
            }
            else if (label1.Text == "Pra Remaja Kelas B")
            {
                praremajaba(); praremajab6();
                praremajabA();
                praremajab4();
                praremajab5();
                praremajab3();
            }
            else if (label1.Text == "Pra Remaja Kelas C")
            {
                praremajaca(); praremajac6();
                praremajac3(); praremajac5();
                praremajac4();
                praremajacA();
            }
            else if (label1.Text == "Pra Remaja Kelas D")
            {
                praremajada(); praremajad6();
                praremajadA(); praremajad5();
                praremajad3();
                praremajad4();
            }
            else if (label1.Text == "Pra Remaja Kelas E")
            {
                praremajae(); praremajae5();
                praremajae4(); praremajae6();
                praremajaea();
                praremajae3();
            }
            else if (label1.Text == "Pra Remaja Kelas F")
            {
                praremajafA(); praremajaf5();
                praremajaf(); praremajaf6();
                praremajaf4();
                praremajaf3();
            }
            else if (label1.Text == "Pra Remaja Kelas G")
            {
                praremajag(); praremajag5();
                praremajag3(); praremajag6();
                praremajaAg();
                praremajag4();
            }
            else if (label1.Text == "Pra Remaja Kelas H")
            {
                praremajah(); praremajah6();
                praremajah4(); praremajah5();
                praremajah3();
                praremajaAh();
            }
            else if (label1.Text == "Pra Remaja Kelas I")
            {
                praremajai(); praremajai5();
                praremajai3(); praremajai6();
                praremajai4();
                praremajaiA();
            }
            else if (label1.Text == "Remaja Kelas A")
            {
                remajaa(); remajaa5();
                remajaa3(); remajaa4();
                remajaA(); remajaa6();
            }
            else if (label1.Text == "Remaja Kelas B")
            {
                remajaba(); remajab5();
                remajab3(); remajab4();
                remajabA(); remajab6();
            }
            else if (label1.Text == "Remaja Kelas C")
            {
                remajac3(); remajac5();
                remajaca(); remajac4();
                remajacA(); remajac6();
            }
            else if (label1.Text == "Remaja Kelas D")
            {
                remajad3(); remajad5();
                remajada(); remajad4();
                remajadaA(); remajad6();
            }
            else if (label1.Text == "Remaja Kelas E")
            {
                remajae3(); remajae5();
                remajae(); remajae4();
                remajaea(); remajae6();
            }
            else if (label1.Text == "Remaja Kelas F")
            {
                remajaf3(); remajaf5();
                remajafA(); remajaf4();
                remajafs(); remajaf6();
            }
            else if (label1.Text == "Remaja Kelas G")
            {
                remajag3(); remajag5();
                remajag(); remajag4();
                remajaAg(); remajag6();
            }
            else if (label1.Text == "Remaja Kelas H")
            {
                remajah3(); remajah5();
                remajah(); remajah4();
                remajaAh(); remajah6();
            }
            else if (label1.Text == "Remaja Kelas I")
            {
                remajai3(); remajai5();
                remajai(); remajai4();
                remajaiA(); remajai6();
            }
            else if (label1.Text == "Dewasa Kelas A")
            {
                dewasaa1(); dewasaa5();
                dewasaa3(); dewasaa4();
                dewasaa2(); dewasaa6();
            }
            else if (label1.Text == "Dewasa Kelas B")
            {
                dewasab1(); dewasab5();
                dewasab2(); dewasab4();
                dewasab3(); dewasab6();
            }
            else if (label1.Text == "Dewasa Kelas C")
            {
                dewasac1(); dewasac5();
                dewasac3(); dewasac4();
                dewasac2(); dewasac6();
            }
            else if (label1.Text == "Dewasa Kelas D")
            {
                dewasad1(); dewasad5();
                dewasad3(); dewasad4();
                dewasad2(); dewasad6();
            }
            else if (label1.Text == "Dewasa Kelas E")
            {
                dewasae1(); dewasae5();
                dewasae3(); dewasae4();
                dewasae2(); dewasae6();
            }
            else if (label1.Text == "Dewasa Kelas F")
            {
                dewasaf1(); dewasaf5();
                dewasaf3(); dewasaf4();
                dewasaf2(); dewasaf6();
            }
            else if (label1.Text == "Dewasa Kelas G")
            {
                dewasag1(); dewasag5();
                dewasag3(); dewasag4();
                dewasag2(); dewasag6();
            }
            else if (label1.Text == "Dewasa Kelas H")
            {
                dewasah1(); dewasah5();
                dewasah3(); dewasah4();
                dewasah2(); dewasah6();
            }
            else if (label1.Text == "Dewasa Kelas I")
            {
                dewasai1(); dewasai5();
                dewasai2(); dewasai4();
                dewasai3(); dewasai6();
            }
            else
            {
                MessageBox.Show("coba lagi");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void b66_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 300;
            if (panel1.Width >= 1400)
            {

                masingmasingbagan();
                timer1.Stop();

            }
        }

    }
}
