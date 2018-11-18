using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipe_Farm
{
    class Field
    {
        // max space of the field
        public int fieldCapacity = 50;

        // creating an instance of the crop class
        public Crops crops;

        // creating a new list, which will be used to store crops in the field
        List<Field> field = new List<Field>();

        // If there is no crop in the field will be equal to null, stored in this method
        public bool FreeSpace()
        {
            return crops == null;

        }


        // The method for adding crop to a field, will iterate through the list, and identify the first available space in the field
        public void AddCropToField(Crops crops)
        {
            for (int i = 0; i < fieldCapacity; i++)
            {
                int availableSpaceIndex = -1;

                if ( FreeSpace())
                {
                    availableSpaceIndex = i;

                }

                else
                {
                    break;

                }

            }

            
        }

    }
}
