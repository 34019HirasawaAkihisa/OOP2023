﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class SalesCounter {

        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        //カテゴリ別の売り上げを求める
        public IDictionary<string, int> GetPerProductCategory() {
            var dict = new SortedDictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory))
                    dict[sale.ProductCategory] += sale.Amount;　//カテゴリが既に存在する
                else
                    dict[sale.ProductCategory] = sale.Amount; //カテゴリが存在しない (新規格納)
            }
            return dict;
        }

        //店舗別の売り上げを求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new SortedDictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;　//店名が既に存在する
                else
                    dict[sale.ShopName] = sale.Amount; //店名が存在しない (新規格納)
            }
            return dict;
        }

        //売上データを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(string filePath) {
           var sales = new List<Sale>(); //売上データを格納する
            var lines = File.ReadAllLines(filePath);　//ファイルからすべてのデータを読み込む

            foreach (var line in lines) { //すべての行から一行ずつ取り出す

                var items = line.Split(','); //区切りで項目別に分ける
                var sale = new Sale {　//Saleインスタンスを生成
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),
                };
                sales.Add(sale); //Saleインスタンスをコレクションに追加
            }

            return sales;
        }
    }
}
