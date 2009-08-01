using System.Drawing;

namespace Administrator.Data
{
    public partial class PersonList
    {
        public string FullName
        {
            get { return string.Format("{0} {1} {2}", Surname, FirstName, LastName); }
        }

        public Image Photo
        {
            set { Image = Utils.ImgToBytes(value); }

            get
            {
                if (Image == null) return Sex ? Properties.Resources.businessman2 : Properties.Resources.woman4;

                return Utils.BytesToImg(Image);
            }
        }
    }
}
