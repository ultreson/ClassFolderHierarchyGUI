using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace session
{
    public class ListeDeCours:List<Cours>
    {
        #region variables et propriété

        public int NombreDeCours
        {
            get
            {
                return Count;
            }
        }

        #endregion

        #region constructeur

        public ListeDeCours()
        {

        }

        #endregion

        #region methodes

        public Cours CoursAt(int pIndex)
        {
            return this[pIndex];
        }

        #endregion

    }
}