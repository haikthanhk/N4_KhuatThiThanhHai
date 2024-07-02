using KoreaNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KoreaNews.Logics
{
    public class ImageManager
    {

        public List<Image> GetAllImagesByNewsId(int NewsId)
        {
            using (var context = new KoreaNewsContext())
            {
                return context.Images.Where(x => x.NewsId == NewsId).ToList();
            }
        }

        public void DeleteImagesById(int NewsId)
        {
            using (var context = new KoreaNewsContext())
            {
                List<Image> im = context.Images.Where(x => x.NewsId == NewsId).ToList();
                foreach (Image i in im)
                {
                    context.Remove(i);
                    context.SaveChanges();
                }
            }
        }

        public void AddImages(int NewsId, string ImageUrl)
        {
            using (var context = new KoreaNewsContext())
            {
                Image i = new Image
                {
                    ImageUrl = ImageUrl,
                    NewsId = NewsId,
                };
                context.Add(i);
                context.SaveChanges();
            }
        }

        public Image GetLastImage()
        {
            using (var context = new KoreaNewsContext())
            {
                return context.Images.Take(1).OrderByDescending(x => x.ImageId).FirstOrDefault();
            }
        }

        public void UpdateImages(int NewsId, string ImageUrl)
        {
            using (var context = new KoreaNewsContext())
            {
                Image i = context.Images.Where(x => x.NewsId == NewsId).FirstOrDefault();
                i.ImageUrl = ImageUrl;
                context.SaveChanges();
            }
        }
    }
}
