using System;

namespace waifu.Helper
{
    public class DataHelper
    {
        private Data _db = new Data();

        public string GetHairData(){
            var array = _db.GetHairData();
            var length = array.Length;
            var random = new Random().Next(length);
            var result = array[random];
            return result;
        }

        public string GetAttrData(){
            var array = _db.GetAttributeData();
            var length = array.Length;
            var random = new Random().Next(length);
            var result = array[random];
            return result;
        }

        public string GetCharData(){
            var array = _db.GetCharacterData();
            var length = array.Length;
            var random = new Random().Next(length);
            var result = array[random];
            return result;
        }

        public string GetCupData(){
            var array = _db.GetCupsizeData();
            var length = array.Length;
            var random = new Random().Next(length);
            var result = array[random];
            return result;
        }

        public string GetSkinData(){
            var array = _db.GetSkinData();
            var length = array.Length;
            var random = new Random().Next(length);
            var result = array[random];
            return result;
        }

        public string GetAgeData(){
            var age = new Random().Next(5,25);
            return age.ToString();
        }

        public string GetHeightData(){
            var height = new Random().Next(143,180);
            return height.ToString();
        }

        public string GetWeightData(){
            var weight = new Random().Next(45,60);
            return weight.ToString();
        }
    }
}