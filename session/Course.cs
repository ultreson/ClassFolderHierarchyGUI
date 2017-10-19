using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace session
{
    public class Cours
    {
        #region Constantes

        string[] m_tabListeDeJours = new string[] {"lundi", "mardi", "mercredi","jeudi", "vendredi"};

        #endregion

        #region variables et propriétés

        private string m_nomCours;
        private int m_nbJours;
        private bool[] m_tabBoolJours;

        public string Nom
        {
            get
            {
                return m_nomCours;
            }
        }

        public int NombreDeJours
        {
            get
            {
                return m_nbJours;
            }
        }

        public string[] TabNomsJours
        {
            get
            {
                string[] tabNomJours = new string[NombreDeJours];
                int count = 0;
                for (int jour = 0; jour < 5; jour++)
                {
                    if (m_tabBoolJours[jour])
                    {
                        tabNomJours[count] = m_tabListeDeJours[jour];
                        count++;
                    }
                }
                return tabNomJours;
            }
        }

        #endregion

        #region constructeur

        public Cours(string pNom, bool[] pTabDeJours)
        {
            m_nomCours = pNom;
            m_tabBoolJours = pTabDeJours;
            CalculNombreJours();
        }

        #endregion

        #region

        private void CalculNombreJours()
        {
            m_nbJours = 0;
            foreach (bool item in m_tabBoolJours)
            {
                if (item)
                    m_nbJours++;
            }
        }

        #endregion
    }
}
