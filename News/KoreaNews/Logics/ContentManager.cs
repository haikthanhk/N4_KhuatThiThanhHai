using KoreaNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KoreaNews.Logics
{
    public class ContentManager
    {
        public List<Content> GetAllContents()
        {
            using (var context = new KoreaNewsContext())
            {
                return context.Contents.ToList();
            }
        }

        public List<Content> GetAllContentsByNewsId(int NewsId)
        {
            using (var context = new KoreaNewsContext())
            {
                return context.Contents.Where(x => x.Image.NewsId == NewsId).ToList();
            }
        }

        public void DeleteContentsById(int NewsId)
        {
            using (var context = new KoreaNewsContext())
            {
                List<Content> ct = context.Contents.Where(x => x.Image.NewsId == NewsId).ToList();
                foreach (Content c in ct)
                {
                    context.Remove(c);
                    context.SaveChanges();
                }
            }
        }

        public void AddContents(int ImageId, string Content)
        {
            using (var context = new KoreaNewsContext())
            {
                Content c = new Content
                {
                    Content1 = Content,
                    ImageId = ImageId,
                };
                context.Add(c);
                context.SaveChanges();
            }
        }

    }
}
