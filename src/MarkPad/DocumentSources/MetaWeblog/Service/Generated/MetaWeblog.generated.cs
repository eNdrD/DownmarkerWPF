//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CookComputing.XmlRpc;
using MarkPad.Settings.Models;

namespace MarkPad.DocumentSources.MetaWeblog.Service
{
    partial class MetaWeblog : XmlRpcClientProtocol
    {
        [XmlRpcMethod("blogger.deletePost")]
        public bool DeletePost(string key, string postid, string username, string password, bool publish)
        {
            return (bool)Invoke("DeletePost", new object[] { key, postid, username, password, publish });
        }

        public IAsyncResult BeginDeletePost(string key, string postid, string username, string password, bool publish, AsyncCallback callback, object asyncState) 
        { 
            return BeginInvoke("DeletePost", new object[] { key, postid, username, password, publish }, this, callback, asyncState);    
        } 

        public bool EndDeletePost(IAsyncResult asr) 
        { 
            return (bool)EndInvoke(asr); 
        } 

        public Task<bool> DeletePostAsync(string key, string postid, string username, string password, bool publish)
        {
            return Task<bool>.Factory.FromAsync(BeginDeletePost(key, postid, username, password, publish, null, null), EndDeletePost);
        }

        [XmlRpcMethod("blogger.getUsersBlogs")]
        public BlogInfo[] GetUsersBlogs(string key, string username, string password)
        {
            return (BlogInfo[])Invoke("GetUsersBlogs", new object[] { key, username, password });
        }

        public IAsyncResult BeginGetUsersBlogs(string key, string username, string password, AsyncCallback callback, object asyncState) 
        { 
            return BeginInvoke("GetUsersBlogs", new object[] { key, username, password }, this, callback, asyncState);    
        } 

        public BlogInfo[] EndGetUsersBlogs(IAsyncResult asr) 
        { 
            return (BlogInfo[])EndInvoke(asr); 
        } 

        public Task<BlogInfo[]> GetUsersBlogsAsync(string key, string username, string password)
        {
            return Task<BlogInfo[]>.Factory.FromAsync(BeginGetUsersBlogs, EndGetUsersBlogs, key, username, password, null);
        }

        [XmlRpcMethod("blogger.getUserInfo")]
        public UserInfo GetUserInfo(string key, string username, string password)
        {
            return (UserInfo)Invoke("GetUserInfo", new object[] { key, username, password });
        }

        public IAsyncResult BeginGetUserInfo(string key, string username, string password, AsyncCallback callback, object asyncState) 
        { 
            return BeginInvoke("GetUserInfo", new object[] { key, username, password }, this, callback, asyncState);    
        } 

        public UserInfo EndGetUserInfo(IAsyncResult asr) 
        { 
            return (UserInfo)EndInvoke(asr); 
        } 

        public Task<UserInfo> GetUserInfoAsync(string key, string username, string password)
        {
            return Task<UserInfo>.Factory.FromAsync(BeginGetUserInfo, EndGetUserInfo, key, username, password, null);
        }

        [XmlRpcMethod("metaWeblog.newPost")]
        public string NewPost(string blogid, string username, string password, Post post, bool publish)
        {
            return (string)Invoke("NewPost", new object[] { blogid, username, password, post, publish });
        }

        public IAsyncResult BeginNewPost(string blogid, string username, string password, Post post, bool publish, AsyncCallback callback, object asyncState) 
        { 
            return BeginInvoke("NewPost", new object[] { blogid, username, password, post, publish }, this, callback, asyncState);    
        } 

        public string EndNewPost(IAsyncResult asr) 
        { 
            return (string)EndInvoke(asr); 
        } 

        public Task<string> NewPostAsync(string blogid, string username, string password, Post post, bool publish)
        {
            return Task<string>.Factory.FromAsync(BeginNewPost(blogid, username, password, post, publish, null, null), EndNewPost);
        }

        [XmlRpcMethod("metaWeblog.editPost")]
        public bool EditPost(string postid, string username, string password, Post post, bool publish)
        {
            return (bool)Invoke("EditPost", new object[] { postid, username, password, post, publish });
        }

        public IAsyncResult BeginEditPost(string postid, string username, string password, Post post, bool publish, AsyncCallback callback, object asyncState) 
        { 
            return BeginInvoke("EditPost", new object[] { postid, username, password, post, publish }, this, callback, asyncState);    
        } 

        public bool EndEditPost(IAsyncResult asr) 
        { 
            return (bool)EndInvoke(asr); 
        } 

        public Task<bool> EditPostAsync(string postid, string username, string password, Post post, bool publish)
        {
            return Task<bool>.Factory.FromAsync(BeginEditPost(postid, username, password, post, publish, null, null), EndEditPost);
        }

        [XmlRpcMethod("metaWeblog.getPost")]
        public Post GetPost(string postid, string username, string password)
        {
            return (Post)Invoke("GetPost", new object[] { postid, username, password });
        }

        public IAsyncResult BeginGetPost(string postid, string username, string password, AsyncCallback callback, object asyncState) 
        { 
            return BeginInvoke("GetPost", new object[] { postid, username, password }, this, callback, asyncState);    
        } 

        public Post EndGetPost(IAsyncResult asr) 
        { 
            return (Post)EndInvoke(asr); 
        } 

        public Task<Post> GetPostAsync(string postid, string username, string password)
        {
            return Task<Post>.Factory.FromAsync(BeginGetPost, EndGetPost, postid, username, password, null);
        }

        [XmlRpcMethod("metaWeblog.getCategories")]
        public CategoryInfo[] GetCategories(string blogid, string username, string password)
        {
            return (CategoryInfo[])Invoke("GetCategories", new object[] { blogid, username, password });
        }

        public IAsyncResult BeginGetCategories(string blogid, string username, string password, AsyncCallback callback, object asyncState) 
        { 
            return BeginInvoke("GetCategories", new object[] { blogid, username, password }, this, callback, asyncState);    
        } 

        public CategoryInfo[] EndGetCategories(IAsyncResult asr) 
        { 
            return (CategoryInfo[])EndInvoke(asr); 
        } 

        public Task<CategoryInfo[]> GetCategoriesAsync(string blogid, string username, string password)
        {
            return Task<CategoryInfo[]>.Factory.FromAsync(BeginGetCategories, EndGetCategories, blogid, username, password, null);
        }

        [XmlRpcMethod("metaWeblog.getRecentPosts")]
        public Post[] GetRecentPosts(string blogid, string username, string password, int numberOfPosts)
        {
            return (Post[])Invoke("GetRecentPosts", new object[] { blogid, username, password, numberOfPosts });
        }

        public IAsyncResult BeginGetRecentPosts(string blogid, string username, string password, int numberOfPosts, AsyncCallback callback, object asyncState) 
        { 
            return BeginInvoke("GetRecentPosts", new object[] { blogid, username, password, numberOfPosts }, this, callback, asyncState);    
        } 

        public Post[] EndGetRecentPosts(IAsyncResult asr) 
        { 
            return (Post[])EndInvoke(asr); 
        } 

        public Task<Post[]> GetRecentPostsAsync(string blogid, string username, string password, int numberOfPosts)
        {
            return Task<Post[]>.Factory.FromAsync(BeginGetRecentPosts(blogid, username, password, numberOfPosts, null, null), EndGetRecentPosts);
        }

        [XmlRpcMethod("metaWeblog.newMediaObject")]
        public MediaObjectInfo NewMediaObject(string blogid, string username, string password, MediaObject mediaObject)
        {
            return (MediaObjectInfo)Invoke("NewMediaObject", new object[] { blogid, username, password, mediaObject });
        }

        public IAsyncResult BeginNewMediaObject(string blogid, string username, string password, MediaObject mediaObject, AsyncCallback callback, object asyncState) 
        { 
            return BeginInvoke("NewMediaObject", new object[] { blogid, username, password, mediaObject }, this, callback, asyncState);    
        } 

        public MediaObjectInfo EndNewMediaObject(IAsyncResult asr) 
        { 
            return (MediaObjectInfo)EndInvoke(asr); 
        } 

        public Task<MediaObjectInfo> NewMediaObjectAsync(string blogid, string username, string password, MediaObject mediaObject)
        {
            return Task<MediaObjectInfo>.Factory.FromAsync(BeginNewMediaObject(blogid, username, password, mediaObject, null, null), EndNewMediaObject);
        }

    }
}
