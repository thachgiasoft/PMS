﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KhoiLuongGiangDayChiTietTest.cs instead.
*/

#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;

#endregion

namespace PMS.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="KhoiLuongGiangDayChiTiet"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KhoiLuongGiangDayChiTietTest
    {
    	// the KhoiLuongGiangDayChiTiet instance used to test the repository.
		protected KhoiLuongGiangDayChiTiet mock;
		
		// the TList<KhoiLuongGiangDayChiTiet> instance used to test the repository.
		protected TList<KhoiLuongGiangDayChiTiet> mockCollection;
		
		protected static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
			}			
			return transactionManager;
		}
		       
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {		
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the KhoiLuongGiangDayChiTiet Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {   		
			System.Console.WriteLine("All Tests Completed");
			System.Console.WriteLine();
        }
    
    
		/// <summary>
		/// Inserts a mock KhoiLuongGiangDayChiTiet entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayChiTietProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayChiTietProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KhoiLuongGiangDayChiTiet objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KhoiLuongGiangDayChiTietProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayChiTietProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KhoiLuongGiangDayChiTietProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KhoiLuongGiangDayChiTiet children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KhoiLuongGiangDayChiTietProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KhoiLuongGiangDayChiTietProvider.DeepLoading += new EntityProviderBaseCore<KhoiLuongGiangDayChiTiet, KhoiLuongGiangDayChiTietKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KhoiLuongGiangDayChiTietProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KhoiLuongGiangDayChiTiet instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KhoiLuongGiangDayChiTietProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KhoiLuongGiangDayChiTiet entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongGiangDayChiTiet mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayChiTietProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayChiTietProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayChiTietProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KhoiLuongGiangDayChiTiet entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KhoiLuongGiangDayChiTiet)CreateMockInstance(tm);
				DataRepository.KhoiLuongGiangDayChiTietProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KhoiLuongGiangDayChiTietProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KhoiLuongGiangDayChiTietProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KhoiLuongGiangDayChiTiet entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayChiTiet.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KhoiLuongGiangDayChiTiet entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayChiTiet.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KhoiLuongGiangDayChiTiet>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KhoiLuongGiangDayChiTiet collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayChiTietCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KhoiLuongGiangDayChiTiet> mockCollection = new TList<KhoiLuongGiangDayChiTiet>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KhoiLuongGiangDayChiTiet> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KhoiLuongGiangDayChiTiet collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongGiangDayChiTietCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KhoiLuongGiangDayChiTiet>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KhoiLuongGiangDayChiTiet> mockCollection = (TList<KhoiLuongGiangDayChiTiet>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KhoiLuongGiangDayChiTiet> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongGiangDayChiTiet entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayChiTietProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongGiangDayChiTiet entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayChiTietProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KhoiLuongGiangDayChiTiet t0 = DataRepository.KhoiLuongGiangDayChiTietProvider.GetByMaKhoiLuong(tm, entity.MaKhoiLuong);
			}
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				
				KhoiLuongGiangDayChiTiet entity = mock.Copy() as KhoiLuongGiangDayChiTiet;
				entity = (KhoiLuongGiangDayChiTiet)mock.Clone();
				Assert.IsTrue(KhoiLuongGiangDayChiTiet.ValueEquals(entity, mock), "Clone is not working");
			}
		}
		
		/// <summary>
		/// Test Find using the Query class
		/// </summary>
		private void Step_30_TestFindByQuery_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Insert Mock Instance
				KhoiLuongGiangDayChiTiet mock = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongGiangDayChiTietProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KhoiLuongGiangDayChiTietQuery query = new KhoiLuongGiangDayChiTietQuery();
			
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaKhoiLuong, mock.MaKhoiLuong.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaLichHoc, mock.MaLichHoc.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.NamHoc, mock.NamHoc.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.HocKy, mock.HocKy.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaMonHoc, mock.MaMonHoc.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.Nhom, mock.Nhom.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.SoTinChi, mock.SoTinChi.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.LyThuyet, mock.LyThuyet.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.ThucHanh, mock.ThucHanh.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.BaiTap, mock.BaiTap.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.BaiTapLon, mock.BaiTapLon.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.DoAn, mock.DoAn.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.LuanAn, mock.LuanAn.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.TieuLuan, mock.TieuLuan.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.ThucTap, mock.ThucTap.ToString());
				if(mock.SoLuong != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.SoLuong, mock.SoLuong.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.LoaiHocPhan != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.LoaiHocPhan, mock.LoaiHocPhan.ToString());
				if(mock.PhanLoai != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.PhanLoai, mock.PhanLoai.ToString());
				if(mock.HeSoThanhPhan != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.HeSoThanhPhan, mock.HeSoThanhPhan.ToString());
				if(mock.Nam != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.Nam, mock.Nam.ToString());
				if(mock.Tuan != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.Tuan, mock.Tuan.ToString());
				if(mock.DonViTinh != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.DonViTinh, mock.DonViTinh.ToString());
				if(mock.MaBuoiHoc != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaBuoiHoc, mock.MaBuoiHoc.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaLop, mock.MaLop.ToString());
				if(mock.TietBatDau != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.TietBatDau, mock.TietBatDau.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.SoTiet, mock.SoTiet.ToString());
				query.AppendEquals(KhoiLuongGiangDayChiTietColumn.TinhTrang, mock.TinhTrang.ToString());
				if(mock.NgayDay != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.NgayDay, mock.NgayDay.ToString());
				if(mock.Compensate != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.Compensate, mock.Compensate.ToString());
				if(mock.MaBacDaoTao != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaBacDaoTao, mock.MaBacDaoTao.ToString());
				if(mock.MaKhoa != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaKhoa, mock.MaKhoa.ToString());
				if(mock.MaNhomMonHoc != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaNhomMonHoc, mock.MaNhomMonHoc.ToString());
				if(mock.MaPhongHoc != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaPhongHoc, mock.MaPhongHoc.ToString());
				if(mock.MaKhoaHoc != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaKhoaHoc, mock.MaKhoaHoc.ToString());
				if(mock.LoaiHocKy != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.LoaiHocKy, mock.LoaiHocKy.ToString());
				if(mock.HeSoHocKy != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.HeSoHocKy, mock.HeSoHocKy.ToString());
				if(mock.NamThu != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.NamThu, mock.NamThu.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaChucVu != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaChucVu, mock.MaChucVu.ToString());
				if(mock.MaHinhThucDaoTao != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaHinhThucDaoTao, mock.MaHinhThucDaoTao.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.LopHocPhanChuyenNganh != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.LopHocPhanChuyenNganh, mock.LopHocPhanChuyenNganh.ToString());
				if(mock.DotImport != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.DotImport, mock.DotImport.ToString());
				if(mock.DaoTaoTinChi != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.DaoTaoTinChi, mock.DaoTaoTinChi.ToString());
				if(mock.MaCauHinhChotGio != null)
					query.AppendEquals(KhoiLuongGiangDayChiTietColumn.MaCauHinhChotGio, mock.MaCauHinhChotGio.ToString());
				
				TList<KhoiLuongGiangDayChiTiet> results = DataRepository.KhoiLuongGiangDayChiTietProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KhoiLuongGiangDayChiTiet Entity with mock values.
		///</summary>
		static public KhoiLuongGiangDayChiTiet CreateMockInstance_Generated(TransactionManager tm)
		{		
			KhoiLuongGiangDayChiTiet mock = new KhoiLuongGiangDayChiTiet();
						
			mock.MaLichHoc = TestUtility.Instance.RandomNumber();
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.Nhom = TestUtility.Instance.RandomString(9, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.LyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucHanh = (decimal)TestUtility.Instance.RandomShort();
			mock.BaiTap = (decimal)TestUtility.Instance.RandomShort();
			mock.BaiTapLon = (decimal)TestUtility.Instance.RandomShort();
			mock.DoAn = (decimal)TestUtility.Instance.RandomShort();
			mock.LuanAn = (decimal)TestUtility.Instance.RandomShort();
			mock.TieuLuan = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucTap = (decimal)TestUtility.Instance.RandomShort();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.PhanLoai = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoThanhPhan = (decimal)TestUtility.Instance.RandomShort();
			mock.Nam = TestUtility.Instance.RandomNumber();
			mock.Tuan = TestUtility.Instance.RandomNumber();
			mock.DonViTinh = TestUtility.Instance.RandomString(10, false);;
			mock.MaBuoiHoc = TestUtility.Instance.RandomNumber();
			mock.MaLop = TestUtility.Instance.RandomString(126, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			mock.Compensate = TestUtility.Instance.RandomByte();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(99, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaPhongHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.LoaiHocKy = TestUtility.Instance.RandomByte();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.NamThu = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaChucVu = TestUtility.Instance.RandomNumber();
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(126, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.LopHocPhanChuyenNganh = TestUtility.Instance.RandomBoolean();
			mock.DotImport = TestUtility.Instance.RandomString(99, false);;
			mock.DaoTaoTinChi = TestUtility.Instance.RandomBoolean();
			mock.MaCauHinhChotGio = TestUtility.Instance.RandomNumber();
			
		
			// create a temporary collection and add the item to it
			TList<KhoiLuongGiangDayChiTiet> tempMockCollection = new TList<KhoiLuongGiangDayChiTiet>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KhoiLuongGiangDayChiTiet)mock;
		}
		
		
		///<summary>
		///  Update the Typed KhoiLuongGiangDayChiTiet Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KhoiLuongGiangDayChiTiet mock)
		{
			mock.MaLichHoc = TestUtility.Instance.RandomNumber();
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.Nhom = TestUtility.Instance.RandomString(9, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.LyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucHanh = (decimal)TestUtility.Instance.RandomShort();
			mock.BaiTap = (decimal)TestUtility.Instance.RandomShort();
			mock.BaiTapLon = (decimal)TestUtility.Instance.RandomShort();
			mock.DoAn = (decimal)TestUtility.Instance.RandomShort();
			mock.LuanAn = (decimal)TestUtility.Instance.RandomShort();
			mock.TieuLuan = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucTap = (decimal)TestUtility.Instance.RandomShort();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.PhanLoai = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoThanhPhan = (decimal)TestUtility.Instance.RandomShort();
			mock.Nam = TestUtility.Instance.RandomNumber();
			mock.Tuan = TestUtility.Instance.RandomNumber();
			mock.DonViTinh = TestUtility.Instance.RandomString(10, false);;
			mock.MaBuoiHoc = TestUtility.Instance.RandomNumber();
			mock.MaLop = TestUtility.Instance.RandomString(126, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			mock.Compensate = TestUtility.Instance.RandomByte();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(99, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaPhongHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.LoaiHocKy = TestUtility.Instance.RandomByte();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.NamThu = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaChucVu = TestUtility.Instance.RandomNumber();
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(126, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.LopHocPhanChuyenNganh = TestUtility.Instance.RandomBoolean();
			mock.DotImport = TestUtility.Instance.RandomString(99, false);;
			mock.DaoTaoTinChi = TestUtility.Instance.RandomBoolean();
			mock.MaCauHinhChotGio = TestUtility.Instance.RandomNumber();
			
		}
		#endregion
    }
}
