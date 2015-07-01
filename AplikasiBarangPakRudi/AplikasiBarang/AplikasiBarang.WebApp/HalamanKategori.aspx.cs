using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AplikasiBarang.DAL.Model;
using AplikasiBarang.DAL.Dao;

namespace AplikasiBarang.WebApp
{
    public partial class HalamanKategori : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // membuat objek/variabel kategori
            KategoriBarang kategori = new KategoriBarang();
            kategori.KategoriID = Convert.ToInt32(txtKategoriID.Text);
            kategori.NamaKategori = txtNamaKategori.Text;

            // membuat objek/variabel kategori barang dao
            KategoriBarangDao kategoriDao = new KategoriBarangDao();
            int hasil = kategoriDao.Save(kategori);

            if (hasil > 0)
                lblKeterangan.Text = "Tambah data kategori berhasil";
            else
                lblKeterangan.Text = "Tambah data kategori gagal";

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            // membuat objek/variabel kategori
            KategoriBarang kategori = new KategoriBarang();
            kategori.KategoriID = Convert.ToInt32(txtKategoriID.Text);
            kategori.NamaKategori = txtNamaKategori.Text;

            // membuat objek/variabel kategori barang dao
            KategoriBarangDao kategoriDao = new KategoriBarangDao();
            int hasil = kategoriDao.Update(kategori);

            if (hasil > 0)
                lblKeterangan.Text = "Update data kategori berhasil";
            else
                lblKeterangan.Text = "Update data kategori gagal";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // membuat objek/variabel kategori
            KategoriBarang kategori = new KategoriBarang();
            kategori.KategoriID = Convert.ToInt32(txtKategoriID.Text);

            // membuat objek/variabel kategori barang dao
            KategoriBarangDao kategoriDao = new KategoriBarangDao();
            int hasil = kategoriDao.Delete(kategori);

            if (hasil > 0)
                lblKeterangan.Text = "Delete data kategori berhasil";
            else
                lblKeterangan.Text = "Delete data kategori gagal";
        }

        protected void btnTampilkanData_Click(object sender, EventArgs e)
        {
            // membuat objek/variabel kategori barang dao
            KategoriBarangDao kategoriDao = new KategoriBarangDao();
            List<KategoriBarang> hasil = kategoriDao.GetAll();

            gvKategoriBarang.DataSource = hasil;
            gvKategoriBarang.DataBind();
        }

        protected void btnCari_Click(object sender, EventArgs e)
        {
            // membuat objek/variabel kategori barang dao
            KategoriBarangDao kategoriDao = new KategoriBarangDao();
            List<KategoriBarang> hasil = kategoriDao.GetByName(txtCari.Text);

            gvKategoriBarang.DataSource = hasil;
            gvKategoriBarang.DataBind();
        }

        protected void btnCariById_Click(object sender, EventArgs e)
        {
            // membuat objek/variabel kategori barang dao
            KategoriBarangDao kategoriDao = new KategoriBarangDao();
            KategoriBarang kategori = kategoriDao.GetByID(Convert.ToInt32(txtKategoriID.Text));

            if (kategori != null)
            {
                txtNamaKategori.Text = kategori.NamaKategori;
                lblKeterangan.Text = "Data ditemukan";
            }
            else
                lblKeterangan.Text = "Data Tidak ditemukan";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // membuat objek/variabel kategori barang dao
            KategoriBarangDao kategoriDao = new KategoriBarangDao();
            List<KategoriBarang> hasil = kategoriDao.GetAll();

            dropKategori.DataSource = hasil;
            dropKategori.DataValueField = "NamaKategori";
            dropKategori.DataBind();
        }
    }
}