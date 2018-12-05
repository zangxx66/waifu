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
    }
}