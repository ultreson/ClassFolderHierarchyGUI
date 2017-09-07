using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace session
{
    public class Session
    {
        private ListeDeCours m_listeDeCours = new ListeDeCours();
        private string m_Nom;

        public string Nom
        {
            get
            {
                return m_Nom;
            }
        }

        public ListeDeCours Liste
        {
            get
            {
                return m_listeDeCours;
            }
        }

        public Session(string pNom)
        {
            m_Nom = pNom;
        }

        public void Creer(string path)
        {
            Directory.CreateDirectory(path + "\\" + m_Nom);
            path = path + "\\" + m_Nom;
            StringBuilder NomCours = new StringBuilder(path);
            foreach (Cours cours in m_listeDeCours)
            {
                path = NomCours.ToString();
                Directory.CreateDirectory(path + "\\" + cours.Nom);
                path = path + "\\" + cours.Nom;
                StringBuilder rappel = new StringBuilder(path);
                for (int semaine = 1; semaine < 16; semaine++)
                {
                    path = rappel.ToString();
                    Directory.CreateDirectory(path + "\\semaine " + semaine.ToString("00"));
                    path = path + "\\semaine " + semaine.ToString("00");
                    if (cours.PlusieursJours())
                    {
                        for (int jour = 0; jour < cours.NombreDeJours; jour++)
                        {
                            Directory.CreateDirectory(path + "\\" + cours.TabNomsJours[jour]);
                        }
                    }
                }
            }
        }
    }
}