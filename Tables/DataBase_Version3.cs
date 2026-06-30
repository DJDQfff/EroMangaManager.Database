using Database.Entities;

using Microsoft.EntityFrameworkCore;

using System.Diagnostics;

namespace Database.Tables
{
    /// <summary>
    /// 数据库类
    /// </summary>
    /// <remarks>
    ///
    /// </remarks>
    /// <param name="connectionString"></param>
    public class DataBase_Version3 (string connectionString) : DbContext
    {

        /// <summary>
        /// 存储用户添加的不显示的图片的数据库表
        /// </summary>
        public DbSet<FilteredImage> FilteredImages { set; get; }

        /// <summary>
        /// UniqueTagInRelation数据表
        /// </summary>
        public DbSet<TagCategory> TagCategorys { set; get; }

        /// <summary>
        /// ReadingInfo数据表
        /// </summary>
        public DbSet<ReadingInfo> ReadingInfos { set; get; }

        /// <summary>
        ///访问文件夹存储
        /// </summary>
        public DbSet<MangaFolder> MangaFolders { set; get; }

        /// <summary>
        ///访问文件夹存储
        /// </summary>
        public DbSet<UWPAccessIStorage> UWPAccessIStorages { set; get; }

        /// <summary>
        /// 配置数据库
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            Debug.WriteLine(connectionString);
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}