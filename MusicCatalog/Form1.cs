using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicCatalog
{
    public partial class Form1 : Form
    {
        public List<Singer> Singers {  get; set; }
        public List<Songbook> Songbooks {  get; set; }

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            Search();
        }

        private void Search(string search = "")
        {
            var type = comboBox1.SelectedItem.ToString();
            (Singers, Songbooks) = IniSeed.GetDefoult();
            if (search == "")
            {
                if (comboBox1.SelectedItem == "Сборники")
                {
                    FillDataGrid(new List<Singer>(), Songbooks);
                    return;
                }
                else
                {
                    FillDataGrid(Singers, new List<Songbook>(), type);
                    return;
                }
            }
            
            switch (type)
            {
                case "Сборники":
                    var result1 = Songbooks.Where(o => o.Name.ToLower().Contains(search.ToLower())).ToList();
                    FillDataGrid(new List<Singer>(), result1);
                    break;

                case "Все":
                    break;

                case "Артисты":
                    var result3 = Singers.Where(o => o.Name.ToLower().Contains(search.ToLower())).ToList();
                    FillDataGrid(result3, new List<Songbook>(), type);
                    break;

                case "Альбомы":
                    var result4 = Singers
                    .Select(singer => new Singer
                    {
                        Name = singer.Name,
                        Albums = singer.Albums.Where(album => album.Name.ToLower().Contains(search.ToLower())).ToList()
                    })
                    .Where(singer => singer.Albums.Any())
                    .ToList();

                    FillDataGrid(result4, new List<Songbook>(), type);
                    break;

                case "Песни":
                    var result5 = new List<Singer>();
                    
                    if (comboBox2.SelectedItem == "Название")
                    {
                        result5 = Singers
                        .Select(singer => new Singer
                        {
                            Name = singer.Name,
                            Albums = singer.Albums.Select(album => new Album
                            {
                                Name = album.Name,
                                Year = album.Year,
                                Songs = album.Songs.Where(song => song.Name.ToLower().Contains(search.ToLower())).ToList()
                            }).Where(album => album.Songs.Any()).ToList()
                        })
                        .Where(singer => singer.Albums.Any())
                        .ToList();
                    }

                    if (comboBox2.SelectedItem == "Жанр")
                    {
                        result5 = Singers
                        .Select(singer => new Singer
                        {
                            Name = singer.Name,
                            Albums = singer.Albums.Select(album => new Album
                            {
                                Name = album.Name,
                                Year = album.Year,
                                Songs = album.Songs.Where(song => song.Genre.ToLower().Contains(search.ToLower())).ToList()
                            }).Where(album => album.Songs.Any()).ToList()
                        })
                        .Where(singer => singer.Albums.Any())
                        .ToList();
                    }

                    if (comboBox2.SelectedItem == "Год" && int.TryParse(search, out int year))
                    {
                        result5 = Singers
                        .Select(singer => new Singer
                        {
                            Name = singer.Name,
                            Albums = singer.Albums.Where(album => album.Year.ToString().Contains(year.ToString())).ToList()
                        })
                        .Where(singer => singer.Albums.Any())
                        .ToList();
                    }

                    FillDataGrid(result5, new List<Songbook>());
                    break;
            }
        }

        private void FillDataGrid(List<Singer> singers, List<Songbook> songbooks, string type = "")
        {
            if (singers.Count > 0 && songbooks.Count == 0)
            {
                dataGridView1.Rows.Clear();

                if (type == "Артисты")
                {
                    for (int i = 0; i < singers.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1[0, i].Value = singers[i].Name;
                        dataGridView1.Columns[0].Visible = true;

                        var lNames = singers[i].Albums.Select(o => o.Name).ToList();
                        dataGridView1[1, i].Value = string.Join("\n", lNames);
                        dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dataGridView1.Rows[i].Height = 20 * lNames.Count;
                        
                        dataGridView1.Columns[2].Visible = false;
                        dataGridView1.Columns[3].Visible = false;
                        dataGridView1.Columns[4].Visible = false;
                        dataGridView1.Columns[5].Visible = false;
                    }
                    return;
                }

                if (type == "Альбомы")
                {
                    int rIdx = 0;
                    for (int i = 0; i < singers.Count; i++)
                    {
                        for (int j = 0; j < singers[i].Albums.Count; j++)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1[0, rIdx].Value = singers[i].Name;
                            dataGridView1.Columns[0].Visible = true;
                            dataGridView1[1, rIdx].Value = singers[i].Albums[j].Name;
                            dataGridView1.Columns[1].Visible = true;
                            dataGridView1[2, rIdx].Value = singers[i].Albums[j].Year;
                            dataGridView1.Columns[2].Visible = true;

                            var lNames = singers[i].Albums[j].Songs.Select(o => o.Name).ToList();
                            dataGridView1[3, rIdx].Value = string.Join("\n", lNames);
                            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                            dataGridView1.Rows[rIdx].Height = 20 * lNames.Count;

                            dataGridView1.Columns[3].Visible = true;
                            dataGridView1.Columns[4].Visible = false;
                            dataGridView1.Columns[5].Visible = false;
                            rIdx++;
                        }
                    }
                    return;
                }
               
                int rowIdx = 0;
                for (int i = 0; i < singers.Count; i++)
                {
                    for (int j = 0; j < singers[i].Albums.Count; j++)
                    {
                        for (int k = 0; k < singers[i].Albums[j].Songs.Count; k++)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1[0, rowIdx].Value = singers[i].Name;
                            dataGridView1.Columns[0].Visible = true;
                            dataGridView1[1, rowIdx].Value = singers[i].Albums[j].Name;
                            dataGridView1.Columns[1].Visible = true;
                            dataGridView1[2, rowIdx].Value = singers[i].Albums[j].Year;
                            dataGridView1.Columns[2].Visible = true;
                            dataGridView1[3, rowIdx].Value = singers[i].Albums[j].Songs[k].Name;
                            dataGridView1.Columns[3].Visible = true;
                            dataGridView1[4, rowIdx].Value = singers[i].Albums[j].Songs[k].Genre;
                            dataGridView1.Columns[4].Visible = true;
                            dataGridView1.Columns[5].Visible = false;
                            rowIdx++;

                        }
                    }
                }
            }
            
            else if (singers.Count == 0 && songbooks.Count > 0)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < songbooks.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].Visible = false;


                    var lNames = songbooks[i].Songs.Select(o => o.Name).ToList();

                    dataGridView1[3, i].Value = string.Join("\n", lNames);
                    dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView1.Rows[i].Height = 20 * lNames.Count;

                    dataGridView1.Columns[4].Visible = false;

                    dataGridView1[5, i].Value = songbooks[i].Name;
                    dataGridView1.Columns[5].Visible = true;

                }
            }

            else 
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = comboBox1.SelectedItem;
            if (value == "Песни") comboBox2.Enabled = true;
            else comboBox2.Enabled = false;
            Search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(textBox1.Text);
        }
    }
}
