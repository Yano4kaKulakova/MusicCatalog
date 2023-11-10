using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog
{
    public static class IniSeed
    {
        public static (List<Singer>, List<Songbook>) GetDefoult()
        {
            var singers = new List<Singer>()
            {                             
                new Singer()
                {
                    Name = "Пророк Санбой",
                    Albums = new List<Album>()
                    {
                        new Album()
                        {
                            Name = "Солнышко Смоленское",
                            Year = 2010,
                            Songs = new List<Song>()
                            {
                                new Song()
                                {
                                    Name = "Я вырастал пацаном в Смоленске",
                                    Genre = "Кантри"
                                },

                                new Song()
                                {
                                    Name = "Тройка, семерка, туз",
                                    Genre = "Баллада"
                                },

                                new Song()
                                {
                                    Name = "Остров в океане",
                                    Genre = "Лирика"
                                }
                            }                           
                        }
                    }
                },

                new Singer()
                {
                    Name = "Кулаков Матвей",
                    Albums = new List<Album>()
                    {
                        new Album()
                        {
                            Name = "Выпускной",
                            Year = 2023,
                            Songs = new List<Song>()
                            {
                                new Song()
                                {
                                    Name = "Предпоследний звонок",
                                    Genre = "Лирика"
                                }
                            }
                        },

                        new Album()
                        {
                            Name = "Раннее",
                            Year = 2007,
                            Songs = new List<Song>()
                            {
                                new Song()
                                {
                                    Name = "Тишина",
                                    Genre = "Баллада"
                                },

                                new Song()
                                {
                                    Name = "Крик",
                                    Genre = "Рок"
                                }
                            }
                        }
                    }
                },

                new Singer()
                {
                    Name = "Илья Злотников",
                    Albums = new List<Album>()
                    {
                        new Album()
                        {
                            Name = "Светлана",
                            Year = 2019,
                            Songs = new List<Song>()
                            {
                                new Song()
                                {
                                    Name = "Вернись",
                                    Genre = "Реп"
                                }
                            }
                        },

                        new Album()
                        {
                            Name = "Кристина",
                            Year = 2021,
                            Songs = new List<Song>()
                            {
                                new Song()
                                {
                                    Name = "Вернись 2.0",
                                    Genre = "Реп"
                                },

                                new Song()
                                {
                                    Name = "Кольцо 2.0",
                                    Genre = "Лирика"
                                }
                            }
                        },

                        new Album()
                        {
                            Name = "Баскетбол",
                            Year = 1998,
                            Songs = new List<Song>()
                            {
                                new Song()
                                {
                                    Name = "Кольцо",
                                    Genre = "Реп"
                                }
                            }
                        }
                    }
                },

                new Singer()
                {
                    Name = "Король и Шут",
                    Albums = new List<Album>()
                    {
                        new Album()
                        {
                            Name = "Акустический альбом",
                            Year = 1998,
                            Songs = new List<Song>()
                            {
                                new Song()
                                {
                                    Name = "Кукла колдуна",
                                    Genre = "Рок"
                                },

                                new Song()
                                {
                                    Name = "Прыгну со скалы",
                                    Genre = "Рок"
                                },

                                new Song()
                                {
                                    Name = "Утренний рассвет",
                                    Genre = "Рок"
                                },

                                new Song()
                                {
                                    Name = "Ели мясо мужики",
                                    Genre = "Рок"
                                }
                            }
                        }
                    }
                }
            };

            var songbooks = new List<Songbook>()
            {
                new Songbook()
                {
                    Name = "Грустные треки",
                    Songs = GetSongs("Лирика", ref singers)
                },

                new Songbook()
                {
                    Name = "Веселые треки",
                    Songs = GetSongs("Кантри", ref singers)
                },

                new Songbook()
                {
                    Name = "На любителя",
                    Songs = GetSongs("Реп", ref singers)
                }
            };

            return (singers, songbooks);
        }

        private static List<Song> GetSongs(string genre, ref List<Singer> singers)
        {
            var result = new List<Song>();

            if (singers.Count == 0 || genre.Length == 0) return result;
            foreach (var singer in singers)
            {
                foreach (var album in singer.Albums)
                {
                    var songs = album.Songs.Where(o => o.Genre.ToLower().Contains(genre.ToLower())).ToList();
                    if (songs.Count > 0) result.AddRange(songs);
                }
            }


            return result;
        }
    }
}
