using System.Collections.Generic;
using Nop.Core;
using Nop.Core.Domain.Media;

namespace Nop.Services.Media
{
    /// <summary>
    /// ͼƬ����ӿ�
    /// </summary>
    public partial interface IPictureService
    {
        /// <summary>
        /// ����ͼƬ�洢���û�ȡ���ص�ͼƬ������
        /// </summary>
        /// <param name="picture">Picture</param>
        /// <returns>Picture binary</returns>
        byte[] LoadPictureBinary(Picture picture);

        /// <summary>
        /// ��ȡͼƬSEO�Ѻõ�����
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>Result</returns>
        string GetPictureSeName(string name);

        /// <summary>
        /// ��ȡĬ��ͼƬURL
        /// </summary>
        /// <param name="targetSize">Ĭ�ϴ�С</param>
        /// <param name="defaultPictureType">ͼƬ����</param>
        /// <param name="storeLocation">Store location URL; null to use determine the current store location automatically</param>
        /// <returns>Picture URL</returns>
        string GetDefaultPictureUrl(int targetSize = 0, 
            PictureType defaultPictureType = PictureType.Entity,
            string storeLocation = null);

        /// <summary>
        /// ��ȡͼƬ·��
        /// </summary>
        /// <param name="pictureId">Picture identifier</param>
        /// <param name="targetSize">Ĭ�ϴ�С</param>
        /// <param name="showDefaultPicture">A value indicating whether the default picture is shown</param>
        /// <param name="storeLocation">Store location URL; null to use determine the current store location automatically</param>
        /// <param name="defaultPictureType">ͼƬ����</param>
        /// <returns>Picture URL</returns>
        string GetPictureUrl(int pictureId, 
            int targetSize = 0,
            bool showDefaultPicture = true, 
            string storeLocation = null, 
            PictureType defaultPictureType = PictureType.Entity);

        /// <summary>
        /// ��ȡͼƬURL·��
        /// </summary>
        /// <param name="picture">Pictureʵ��</param>
        /// <param name="targetSize">ͼƬ�ߴ�</param>
        /// <param name="showDefaultPicture">�Ƿ���ʾĬ�ϵ�ͼƬ</param>
        /// <param name="storeLocation">Store location URL; null to use determine the current store location automatically</param>
        /// <param name="defaultPictureType">Ĭ��ͼƬ����</param>
        /// <returns>Picture URL</returns>
        string GetPictureUrl(Picture picture, 
            int targetSize = 0,
            bool showDefaultPicture = true, 
            string storeLocation = null, 
            PictureType defaultPictureType = PictureType.Entity);

        /// <summary>
        /// ��ȡͼƬ����·��
        /// </summary>
        /// <param name="picture">Picture instance</param>
        /// <param name="targetSize">The target picture size (longest side)</param>
        /// <param name="showDefaultPicture">A value indicating whether the default picture is shown</param>
        /// <returns></returns>
        string GetThumbLocalPath(Picture picture, int targetSize = 0, bool showDefaultPicture = true);

        /// <summary>
        /// ��ȡͼƬ
        /// </summary>
        /// <param name="pictureId">Picture identifier</param>
        /// <returns>Picture</returns>
        Picture GetPictureById(int pictureId);

        /// <summary>
        /// ɾ��ͼƬ
        /// </summary>
        /// <param name="picture">Picture</param>
        void DeletePicture(Picture picture);

        /// <summary>
        /// ��ȡͼƬ����
        /// </summary>
        /// <param name="pageIndex">Current page</param>
        /// <param name="pageSize">Items on each page</param>
        /// <returns>Paged list of pictures</returns>
        IPagedList<Picture> GetPictures(int pageIndex = 0, int pageSize = int.MaxValue);

        /// <summary>
        /// ��ID����ȡͼƬ
        /// </summary>
        /// <param name="productId">Product identifier</param>
        /// <param name="recordsToReturn">Ҫ���صļ�¼���� 0��������</param>
        /// <returns>Pictures</returns>
        IList<Picture> GetPicturesByProductId(int productId, int recordsToReturn = 0);

        /// <summary>
        /// ����ͼƬ
        /// </summary>
        /// <param name="pictureBinary">ͼƬ������</param>
        /// <param name="mimeType">ͼƬMIME����</param>
        /// <param name="seoFilename">SEO�ļ���</param>
        /// <param name="altAttribute">��img��HTMLԪ�صġ�alt������</param>
        /// <param name="titleAttribute">��img��HTMLԪ�صġ�title������</param>
        /// <param name="isNew">ͼƬ�Ƿ����µ�ֵ</param>
        /// <param name="validateBinary">ָʾ�Ƿ���֤�ṩ��ͼƬ�����Ƶ�ֵ</param>
        /// <returns>Picture</returns>
        Picture InsertPicture(byte[] pictureBinary, string mimeType, string seoFilename, 
            string altAttribute = null, string titleAttribute = null,
            bool isNew = true, bool validateBinary = true);

        /// <summary>
        /// Updates the picture
        /// </summary>
        /// <param name="pictureId">The picture identifier</param>
        /// <param name="pictureBinary">The picture binary</param>
        /// <param name="mimeType">The picture MIME type</param>
        /// <param name="seoFilename">The SEO filename</param>
        /// <param name="altAttribute">"alt" attribute for "img" HTML element</param>
        /// <param name="titleAttribute">"title" attribute for "img" HTML element</param>
        /// <param name="isNew">A value indicating whether the picture is new</param>
        /// <param name="validateBinary">A value indicating whether to validated provided picture binary</param>
        /// <returns>Picture</returns>
        Picture UpdatePicture(int pictureId, byte[] pictureBinary, string mimeType,
            string seoFilename, string altAttribute = null, string titleAttribute = null,
            bool isNew = true, bool validateBinary = true);

        /// <summary>
        /// ����ͼƬ��SEO�ļ���
        /// </summary>
        /// <param name="pictureId">The picture identifier</param>
        /// <param name="seoFilename">The SEO filename</param>
        /// <returns>Picture</returns>
        Picture SetSeoFilename(int pictureId, string seoFilename);

        /// <summary>
        /// ��֤����ͼƬ�ߴ�
        /// </summary>
        /// <param name="pictureBinary">Picture binary</param>
        /// <param name="mimeType">MIME type</param>
        /// <returns>Picture binary or throws an exception</returns>
        byte[] ValidatePicture(byte[] pictureBinary, string mimeType);

        /// <summary>
        /// ��ȡ������һ��ֵ��ָʾͼ���Ƿ�Ӧ�洢�����ݿ��С�
        /// </summary>
        bool StoreInDb { get; set; }

        /// <summary>
        /// ��ȡͼƬɢ��
        /// </summary>
        /// <param name="picturesIds">Pictures Ids</param>
        /// <returns></returns>
        IDictionary<int, string> GetPicturesHash(int [] picturesIds);
    }
}
