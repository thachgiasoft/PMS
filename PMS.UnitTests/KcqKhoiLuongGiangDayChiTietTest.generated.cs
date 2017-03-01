﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KcqKhoiLuongGiangDayChiTietTest.cs instead.
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
    /// Provides tests for the and <see cref="KcqKhoiLuongGiangDayChiTiet"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KcqKhoiLuongGiangDayChiTietTest
    {
    	// the KcqKhoiLuongGiangDayChiTiet instance used to test the repository.
		protected KcqKhoiLuongGiangDayChiTiet mock;
		
		// the TList<KcqKhoiLuongGiangDayChiTiet> instance used to test the repository.
		protected TList<KcqKhoiLuongGiangDayChiTiet> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KcqKhoiLuongGiangDayChiTiet Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KcqKhoiLuongGiangDayChiTiet entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KcqKhoiLuongGiangDayChiTiet objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KcqKhoiLuongGiangDayChiTietProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KcqKhoiLuongGiangDayChiTiet children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KcqKhoiLuongGiangDayChiTietProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KcqKhoiLuongGiangDayChiTietProvider.DeepLoading += new EntityProviderBaseCore<KcqKhoiLuongGiangDayChiTiet, KcqKhoiLuongGiangDayChiTietKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KcqKhoiLuongGiangDayChiTietProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KcqKhoiLuongGiangDayChiTiet instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KcqKhoiLuongGiangDayChiTietProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KcqKhoiLuongGiangDayChiTiet entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqKhoiLuongGiangDayChiTiet mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KcqKhoiLuongGiangDayChiTiet entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KcqKhoiLuongGiangDayChiTiet)CreateMockInstance(tm);
				DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KcqKhoiLuongGiangDayChiTiet entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqKhoiLuongGiangDayChiTiet.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KcqKhoiLuongGiangDayChiTiet entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqKhoiLuongGiangDayChiTiet.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KcqKhoiLuongGiangDayChiTiet>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KcqKhoiLuongGiangDayChiTiet collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqKhoiLuongGiangDayChiTietCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KcqKhoiLuongGiangDayChiTiet> mockCollection = new TList<KcqKhoiLuongGiangDayChiTiet>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KcqKhoiLuongGiangDayChiTiet> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KcqKhoiLuongGiangDayChiTiet collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqKhoiLuongGiangDayChiTietCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KcqKhoiLuongGiangDayChiTiet>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KcqKhoiLuongGiangDayChiTiet> mockCollection = (TList<KcqKhoiLuongGiangDayChiTiet>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KcqKhoiLuongGiangDayChiTiet> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqKhoiLuongGiangDayChiTiet entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Insert(tm, entity);
				
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
				KcqKhoiLuongGiangDayChiTiet entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KcqKhoiLuongGiangDayChiTiet t0 = DataRepository.KcqKhoiLuongGiangDayChiTietProvider.GetByMaKhoiLuong(tm, entity.MaKhoiLuong);
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
				
				KcqKhoiLuongGiangDayChiTiet entity = mock.Copy() as KcqKhoiLuongGiangDayChiTiet;
				entity = (KcqKhoiLuongGiangDayChiTiet)mock.Clone();
				Assert.IsTrue(KcqKhoiLuongGiangDayChiTiet.ValueEquals(entity, mock), "Clone is not working");
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
				KcqKhoiLuongGiangDayChiTiet mock = CreateMockInstance(tm);
				bool result = DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KcqKhoiLuongGiangDayChiTietQuery query = new KcqKhoiLuongGiangDayChiTietQuery();
			
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaLichHoc, mock.MaLichHoc.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.NamHoc, mock.NamHoc.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.HocKy, mock.HocKy.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaDot, mock.MaDot.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaMonHoc, mock.MaMonHoc.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.Nhom, mock.Nhom.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.SoTinChi, mock.SoTinChi.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.LyThuyet, mock.LyThuyet.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.ThucHanh, mock.ThucHanh.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.BaiTap, mock.BaiTap.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.BaiTapLon, mock.BaiTapLon.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.DoAn, mock.DoAn.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.LuanAn, mock.LuanAn.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.TieuLuan, mock.TieuLuan.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.ThucTap, mock.ThucTap.ToString());
				if(mock.SoLuong != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.SoLuong, mock.SoLuong.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.LoaiHocPhan != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.LoaiHocPhan, mock.LoaiHocPhan.ToString());
				if(mock.PhanLoai != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.PhanLoai, mock.PhanLoai.ToString());
				if(mock.HeSoThanhPhan != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.HeSoThanhPhan, mock.HeSoThanhPhan.ToString());
				if(mock.Nam != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.Nam, mock.Nam.ToString());
				if(mock.Tuan != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.Tuan, mock.Tuan.ToString());
				if(mock.DonViTinh != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.DonViTinh, mock.DonViTinh.ToString());
				if(mock.MaBuoiHoc != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaBuoiHoc, mock.MaBuoiHoc.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaLop, mock.MaLop.ToString());
				if(mock.TietBatDau != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.TietBatDau, mock.TietBatDau.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.LoaiHocKy != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.LoaiHocKy, mock.LoaiHocKy.ToString());
				if(mock.HeSoHocKy != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.HeSoHocKy, mock.HeSoHocKy.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.TinhTrang, mock.TinhTrang.ToString());
				if(mock.NgayDay != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.NgayDay, mock.NgayDay.ToString());
				if(mock.Compensate != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.Compensate, mock.Compensate.ToString());
				query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaKhoiLuong, mock.MaKhoiLuong.ToString());
				if(mock.MaBacDaoTao != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaBacDaoTao, mock.MaBacDaoTao.ToString());
				if(mock.MaKhoa != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaKhoa, mock.MaKhoa.ToString());
				if(mock.MaNhomMonHoc != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaNhomMonHoc, mock.MaNhomMonHoc.ToString());
				if(mock.MaPhongHoc != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaPhongHoc, mock.MaPhongHoc.ToString());
				if(mock.MaKhoaHoc != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaKhoaHoc, mock.MaKhoaHoc.ToString());
				if(mock.NamThu != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.NamThu, mock.NamThu.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaChucVu != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaChucVu, mock.MaChucVu.ToString());
				if(mock.MaHinhThucDaoTao != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.MaHinhThucDaoTao, mock.MaHinhThucDaoTao.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.LopHocPhanChuyenNganh != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.LopHocPhanChuyenNganh, mock.LopHocPhanChuyenNganh.ToString());
				if(mock.DotImport != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.DotImport, mock.DotImport.ToString());
				if(mock.DaoTaoTinChi != null)
					query.AppendEquals(KcqKhoiLuongGiangDayChiTietColumn.DaoTaoTinChi, mock.DaoTaoTinChi.ToString());
				
				TList<KcqKhoiLuongGiangDayChiTiet> results = DataRepository.KcqKhoiLuongGiangDayChiTietProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KcqKhoiLuongGiangDayChiTiet Entity with mock values.
		///</summary>
		static public KcqKhoiLuongGiangDayChiTiet CreateMockInstance_Generated(TransactionManager tm)
		{		
			KcqKhoiLuongGiangDayChiTiet mock = new KcqKhoiLuongGiangDayChiTiet();
						
			mock.MaLichHoc = TestUtility.Instance.RandomNumber();
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
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
			mock.LoaiHocKy = TestUtility.Instance.RandomByte();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			mock.Compensate = TestUtility.Instance.RandomByte();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(99, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaPhongHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
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
			
		
			// create a temporary collection and add the item to it
			TList<KcqKhoiLuongGiangDayChiTiet> tempMockCollection = new TList<KcqKhoiLuongGiangDayChiTiet>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KcqKhoiLuongGiangDayChiTiet)mock;
		}
		
		
		///<summary>
		///  Update the Typed KcqKhoiLuongGiangDayChiTiet Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KcqKhoiLuongGiangDayChiTiet mock)
		{
			mock.MaLichHoc = TestUtility.Instance.RandomNumber();
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
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
			mock.LoaiHocKy = TestUtility.Instance.RandomByte();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			mock.Compensate = TestUtility.Instance.RandomByte();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(99, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaPhongHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
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
			
		}
		#endregion
    }
}
