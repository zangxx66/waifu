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
    }
}