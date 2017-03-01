﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KhoiLuongTamUngTest.cs instead.
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
    /// Provides tests for the and <see cref="KhoiLuongTamUng"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KhoiLuongTamUngTest
    {
    	// the KhoiLuongTamUng instance used to test the repository.
		protected KhoiLuongTamUng mock;
		
		// the TList<KhoiLuongTamUng> instance used to test the repository.
		protected TList<KhoiLuongTamUng> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KhoiLuongTamUng Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KhoiLuongTamUng entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongTamUngProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KhoiLuongTamUngProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KhoiLuongTamUng objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KhoiLuongTamUngProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KhoiLuongTamUngProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KhoiLuongTamUngProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KhoiLuongTamUng children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KhoiLuongTamUngProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KhoiLuongTamUngProvider.DeepLoading += new EntityProviderBaseCore<KhoiLuongTamUng, KhoiLuongTamUngKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KhoiLuongTamUngProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KhoiLuongTamUng instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KhoiLuongTamUngProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KhoiLuongTamUng entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongTamUng mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KhoiLuongTamUngProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KhoiLuongTamUngProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KhoiLuongTamUngProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KhoiLuongTamUng entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KhoiLuongTamUng)CreateMockInstance(tm);
				DataRepository.KhoiLuongTamUngProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KhoiLuongTamUngProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KhoiLuongTamUngProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KhoiLuongTamUng entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongTamUng.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KhoiLuongTamUng entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongTamUng.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KhoiLuongTamUng>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KhoiLuongTamUng collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongTamUngCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KhoiLuongTamUng> mockCollection = new TList<KhoiLuongTamUng>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KhoiLuongTamUng> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KhoiLuongTamUng collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KhoiLuongTamUngCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KhoiLuongTamUng>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KhoiLuongTamUng> mockCollection = (TList<KhoiLuongTamUng>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KhoiLuongTamUng> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KhoiLuongTamUng entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongTamUngProvider.Insert(tm, entity);
				
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
				KhoiLuongTamUng entity = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongTamUngProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KhoiLuongTamUng t0 = DataRepository.KhoiLuongTamUngProvider.GetByMaKhoiLuong(tm, entity.MaKhoiLuong);
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
				
				KhoiLuongTamUng entity = mock.Copy() as KhoiLuongTamUng;
				entity = (KhoiLuongTamUng)mock.Clone();
				Assert.IsTrue(KhoiLuongTamUng.ValueEquals(entity, mock), "Clone is not working");
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
				KhoiLuongTamUng mock = CreateMockInstance(tm);
				bool result = DataRepository.KhoiLuongTamUngProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KhoiLuongTamUngQuery query = new KhoiLuongTamUngQuery();
			
				query.AppendEquals(KhoiLuongTamUngColumn.MaKhoiLuong, mock.MaKhoiLuong.ToString());
				if(mock.MaLichHoc != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaLichHoc, mock.MaLichHoc.ToString());
				if(mock.MaQuanLyGv != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaQuanLyGv, mock.MaQuanLyGv.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(KhoiLuongTamUngColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(KhoiLuongTamUngColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(KhoiLuongTamUngColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(KhoiLuongTamUngColumn.Nhom, mock.Nhom.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(KhoiLuongTamUngColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.SoLuong != null)
					query.AppendEquals(KhoiLuongTamUngColumn.SoLuong, mock.SoLuong.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.LoaiHocPhan != null)
					query.AppendEquals(KhoiLuongTamUngColumn.LoaiHocPhan, mock.LoaiHocPhan.ToString());
				if(mock.MaBuoiHoc != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaBuoiHoc, mock.MaBuoiHoc.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaLop, mock.MaLop.ToString());
				if(mock.TietBatDau != null)
					query.AppendEquals(KhoiLuongTamUngColumn.TietBatDau, mock.TietBatDau.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(KhoiLuongTamUngColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.TinhTrang != null)
					query.AppendEquals(KhoiLuongTamUngColumn.TinhTrang, mock.TinhTrang.ToString());
				if(mock.NgayDay != null)
					query.AppendEquals(KhoiLuongTamUngColumn.NgayDay, mock.NgayDay.ToString());
				if(mock.MaBacDaoTao != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaBacDaoTao, mock.MaBacDaoTao.ToString());
				if(mock.MaKhoa != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaKhoa, mock.MaKhoa.ToString());
				if(mock.MaNhomMonHoc != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaNhomMonHoc, mock.MaNhomMonHoc.ToString());
				if(mock.MaPhongHoc != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaPhongHoc, mock.MaPhongHoc.ToString());
				if(mock.MaKhoaHoc != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaKhoaHoc, mock.MaKhoaHoc.ToString());
				if(mock.LoaiHocKy != null)
					query.AppendEquals(KhoiLuongTamUngColumn.LoaiHocKy, mock.LoaiHocKy.ToString());
				if(mock.NamThu != null)
					query.AppendEquals(KhoiLuongTamUngColumn.NamThu, mock.NamThu.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaChucVu != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaChucVu, mock.MaChucVu.ToString());
				if(mock.MaHinhThucDaoTao != null)
					query.AppendEquals(KhoiLuongTamUngColumn.MaHinhThucDaoTao, mock.MaHinhThucDaoTao.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(KhoiLuongTamUngColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.LopHocPhanChuyenNganh != null)
					query.AppendEquals(KhoiLuongTamUngColumn.LopHocPhanChuyenNganh, mock.LopHocPhanChuyenNganh.ToString());
				if(mock.DotImport != null)
					query.AppendEquals(KhoiLuongTamUngColumn.DotImport, mock.DotImport.ToString());
				if(mock.DaoTaoTinChi != null)
					query.AppendEquals(KhoiLuongTamUngColumn.DaoTaoTinChi, mock.DaoTaoTinChi.ToString());
				if(mock.NgonNguGiangDay != null)
					query.AppendEquals(KhoiLuongTamUngColumn.NgonNguGiangDay, mock.NgonNguGiangDay.ToString());
				
				TList<KhoiLuongTamUng> results = DataRepository.KhoiLuongTamUngProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KhoiLuongTamUng Entity with mock values.
		///</summary>
		static public KhoiLuongTamUng CreateMockInstance_Generated(TransactionManager tm)
		{		
			KhoiLuongTamUng mock = new KhoiLuongTamUng();
						
			mock.MaLichHoc = TestUtility.Instance.RandomNumber();
			mock.MaQuanLyGv = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.Nhom = TestUtility.Instance.RandomString(9, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.MaBuoiHoc = TestUtility.Instance.RandomNumber();
			mock.MaLop = TestUtility.Instance.RandomString(249, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(99, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaPhongHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.LoaiHocKy = TestUtility.Instance.RandomByte();
			mock.NamThu = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaChucVu = TestUtility.Instance.RandomNumber();
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(126, false);;
			mock.LopHocPhanChuyenNganh = TestUtility.Instance.RandomBoolean();
			mock.DotImport = TestUtility.Instance.RandomString(99, false);;
			mock.DaoTaoTinChi = TestUtility.Instance.RandomBoolean();
			mock.NgonNguGiangDay = TestUtility.Instance.RandomString(24, false);;
			
		
			// create a temporary collection and add the item to it
			TList<KhoiLuongTamUng> tempMockCollection = new TList<KhoiLuongTamUng>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KhoiLuongTamUng)mock;
		}
		
		
		///<summary>
		///  Update the Typed KhoiLuongTamUng Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KhoiLuongTamUng mock)
		{
			mock.MaLichHoc = TestUtility.Instance.RandomNumber();
			mock.MaQuanLyGv = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.Nhom = TestUtility.Instance.RandomString(9, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.MaBuoiHoc = TestUtility.Instance.RandomNumber();
			mock.MaLop = TestUtility.Instance.RandomString(249, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
			mock.NgayDay = TestUtility.Instance.RandomDateTime();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoa = TestUtility.Instance.RandomString(99, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaPhongHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.LoaiHocKy = TestUtility.Instance.RandomByte();
			mock.NamThu = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaChucVu = TestUtility.Instance.RandomNumber();
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(126, false);;
			mock.LopHocPhanChuyenNganh = TestUtility.Instance.RandomBoolean();
			mock.DotImport = TestUtility.Instance.RandomString(99, false);;
			mock.DaoTaoTinChi = TestUtility.Instance.RandomBoolean();
			mock.NgonNguGiangDay = TestUtility.Instance.RandomString(24, false);;
			
		}
		#endregion
    }
}
