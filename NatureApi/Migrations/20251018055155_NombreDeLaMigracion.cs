using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureApi.Migrations
{
    /// <inheritdoc />
    public partial class NombreDeLaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "https://aws-tiqets-cdn.imgix.net/images/content/91e400c23f0140abb059eb1958530e84.jpg?auto=format%2Ccompress&fit=crop&ixlib=python-4.0.0&q=70");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://content3.cdnprado.net/imagenes/Documentos/imgsem/c9/c928/c9284595-b7c7-ff6b-92bf-b42cbea3ffdb/5612ce87-ade3-78f4-0baa-b9df91dc7269.jpg");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 3,
                column: "Url",
                value: "https://imagenes.elpais.com/resizer/v2/2PDTE6EQA5G7LFCU7YAOXAD45U.jpg?auth=fd6c8f02f039ef2e06298bb31b3c026ad18cef03b12b9413b866f1fc893bd705&width=414");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "https://media.tacdn.com/media/attractions-splice-spp-674x446/16/15/0b/fc.jpg");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "https://pro.static.holabarcelonablog.tmb.cat/s3fs-public/2020-12/SF.jpg");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-674x446/0f/aa/09/d4.jpg");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "https://cdn-imgix.headout.com/media/images/58da77effa54b9c430bbabfd2a54f135-Alhambra%20Granada.jpeg?auto=format&w=1222.3999999999999&h=687.6&q=90&ar=16%3A9&crop=faces&fit=crop");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 9,
                column: "Url",
                value: "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2a/13/de/d1/caption.jpg?w=900&h=500&s=1");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 10,
                column: "Url",
                value: "https://anpr.org.mx/wp-content/uploads/2023/03/tomado-de-bekia-viajes-anpr-parque-del-mes-1160x560.png");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 11,
                column: "Url",
                value: "https://madridpourvous.com/wp-content/uploads/2018/01/Estanque-Grande-Retiro-Madrid.jpg");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 12,
                column: "Url",
                value: "https://img.nh-hotels.net/8yYbq/rEDOo/original/Spain_Madrid_Retiro.jpg");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 13,
                column: "Url",
                value: "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2f/ff/7b/b5/caption.jpg?w=1200&h=-1&s=1");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 14,
                column: "Url",
                value: "https://www.lacatedraldesevilla.org/img/catedral-sevilla-1.jpg");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 15,
                column: "Url",
                value: "https://www.catedraldesevilla.es/wp-content/uploads/2022/11/vista_catedral_exterior.jpg");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 16,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/9/90/Salamanca_-_Plaza_Mayor_%2813347610863%29_edited.jpg/1200px-Salamanca_-_Plaza_Mayor_%2813347610863%29_edited.jpg");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 17,
                column: "Url",
                value: "https://www.turismocastillayleon.com/en/heritage-culture/main-squares/major-square-salamanca.files/267649-hq_Plaza%20Mayor%20de%20Salamanca01_tr.jpg/h,267649-hq_Plaza%20Mayor%20de%20Salamanca01_tr.jpg");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 18,
                column: "Url",
                value: "https://cdn.getyourguide.com/img/location/56a80a5085eda-wide.jpeg/99.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "https://images.unsplash.com/photo-1578662996442-48f60103fc96");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://images.unsplash.com/photo-1571678264022-e97ed89a33b4");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 3,
                column: "Url",
                value: "https://images.unsplash.com/photo-1594736797933-d0601ba19be5");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "https://images.unsplash.com/photo-1539650116574-75c0c6d00f2f");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "https://images.unsplash.com/photo-1511527844068-006b95d162c2");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "https://images.unsplash.com/photo-1558642452-9d2a7deb7f62");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "https://images.unsplash.com/photo-1605282003441-4828c8b69cd3");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 9,
                column: "Url",
                value: "https://images.unsplash.com/photo-1571663852432-bb0f4e7db0b2");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 10,
                column: "Url",
                value: "https://images.unsplash.com/photo-1584464491033-06628f3a6b7b");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 11,
                column: "Url",
                value: "https://images.unsplash.com/photo-1590075865b93-5b81e33c1321");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 12,
                column: "Url",
                value: "https://images.unsplash.com/photo-1557804506-669a67965ba0");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 13,
                column: "Url",
                value: "https://images.unsplash.com/photo-1571663818459-0bcc3c55a49b");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 14,
                column: "Url",
                value: "https://images.unsplash.com/photo-1633888080670-7c5ad7e6b28d");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 15,
                column: "Url",
                value: "https://images.unsplash.com/photo-1589900670714-25370142cd17");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 16,
                column: "Url",
                value: "https://images.unsplash.com/photo-1546600799-4d0a5d5a158a");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 17,
                column: "Url",
                value: "https://images.unsplash.com/photo-1571663870103-2dd96e4b9c63");

            migrationBuilder.UpdateData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 18,
                column: "Url",
                value: "https://images.unsplash.com/photo-1506905925346-21bda4d32df4");
        }
    }
}
