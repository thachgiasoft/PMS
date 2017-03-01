﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ThanhTraCoiThiTest.cs instead.
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
    /// Provides tests for the and <see cref="ThanhTraCoiThi"/> objects (entity, collection and repository).
    /// </summary>
   public partial class ThanhTraCoiThiTest
    {
    	// the ThanhTraCoiThi instance used to test the repository.
		protected ThanhTraCoiThi mock;
		
		// the TList<ThanhTraCoiThi> instance used to test the repository.
		protected TList<ThanhTraCoiThi> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the ThanhTraCoiThi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock ThanhTraCoiThi entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ThanhTraCoiThiProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.ThanhTraCoiThiProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all ThanhTraCoiThi objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.ThanhTraCoiThiProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.ThanhTraCoiThiProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.ThanhTraCoiThiProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all ThanhTraCoiThi children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.ThanhTraCoiThiProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.ThanhTraCoiThiProvider.DeepLoading += new EntityProviderBaseCore<ThanhTraCoiThi, ThanhTraCoiThiKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.ThanhTraCoiThiProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("ThanhTraCoiThi instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.ThanhTraCoiThiProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock ThanhTraCoiThi entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ThanhTraCoiThi mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ThanhTraCoiThiProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.ThanhTraCoiThiProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.ThanhTraCoiThiProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock ThanhTraCoiThi entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (ThanhTraCoiThi)CreateMockInstance(tm);
				DataRepository.ThanhTraCoiThiProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.ThanhTraCoiThiProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.ThanhTraCoiThiProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ThanhTraCoiThi entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThanhTraCoiThi.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock ThanhTraCoiThi entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThanhTraCoiThi.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<ThanhTraCoiThi>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ThanhTraCoiThi collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThanhTraCoiThiCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<ThanhTraCoiThi> mockCollection = new TList<ThanhTraCoiThi>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<ThanhTraCoiThi> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a ThanhTraCoiThi collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ThanhTraCoiThiCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<ThanhTraCoiThi>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<ThanhTraCoiThi> mockCollection = (TList<ThanhTraCoiThi>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<ThanhTraCoiThi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ThanhTraCoiThi entity = CreateMockInstance(tm);
				bool result = DataRepository.ThanhTraCoiThiProvider.Insert(tm, entity);
				
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
				ThanhTraCoiThi entity = CreateMockInstance(tm);
				bool result = DataRepository.ThanhTraCoiThiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				ThanhTraCoiThi t0 = DataRepository.ThanhTraCoiThiProvider.GetByExaminationMaCanBoCoiThi(tm, entity.Examination, entity.MaCanBoCoiThi);
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
				
				ThanhTraCoiThi entity = mock.Copy() as ThanhTraCoiThi;
				entity = (ThanhTraCoiThi)mock.Clone();
				Assert.IsTrue(ThanhTraCoiThi.ValueEquals(entity, mock), "Clone is not working");
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
				ThanhTraCoiThi mock = CreateMockInstance(tm);
				bool result = DataRepository.ThanhTraCoiThiProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				ThanhTraCoiThiQuery query = new ThanhTraCoiThiQuery();
			
				query.AppendEquals(ThanhTraCoiThiColumn.Examination, mock.Examination.ToString());
				query.AppendEquals(ThanhTraCoiThiColumn.MaCanBoCoiThi, mock.MaCanBoCoiThi.ToString());
				if(mock.NgayThi != null)
					query.AppendEquals(ThanhTraCoiThiColumn.NgayThi, mock.NgayThi.ToString());
				if(mock.ThoiGianBatDau != null)
					query.AppendEquals(ThanhTraCoiThiColumn.ThoiGianBatDau, mock.ThoiGianBatDau.ToString());
				if(mock.MaPhong != null)
					query.AppendEquals(ThanhTraCoiThiColumn.MaPhong, mock.MaPhong.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(ThanhTraCoiThiColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(ThanhTraCoiThiColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(ThanhTraCoiThiColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.ThoiGianLamBai != null)
					query.AppendEquals(ThanhTraCoiThiColumn.ThoiGianLamBai, mock.ThoiGianLamBai.ToString());
				if(mock.TietBatDau != null)
					query.AppendEquals(ThanhTraCoiThiColumn.TietBatDau, mock.TietBatDau.ToString());
				if(mock.MaLopSinhVien != null)
					query.AppendEquals(ThanhTraCoiThiColumn.MaLopSinhVien, mock.MaLopSinhVien.ToString());
				if(mock.SoLuongSinhVien != null)
					query.AppendEquals(ThanhTraCoiThiColumn.SoLuongSinhVien, mock.SoLuongSinhVien.ToString());
				if(mock.MaViPham != null)
					query.AppendEquals(ThanhTraCoiThiColumn.MaViPham, mock.MaViPham.ToString());
				if(mock.MaHinhThucViPhamHrm != null)
					query.AppendEquals(ThanhTraCoiThiColumn.MaHinhThucViPhamHrm, mock.MaHinhThucViPhamHrm.ToString());
				if(mock.SiSoThanhTra != null)
					query.AppendEquals(ThanhTraCoiThiColumn.SiSoThanhTra, mock.SiSoThanhTra.ToString());
				if(mock.ThoiDiemGhiNhan != null)
					query.AppendEquals(ThanhTraCoiThiColumn.ThoiDiemGhiNhan, mock.ThoiDiemGhiNhan.ToString());
				if(mock.LyDo != null)
					query.AppendEquals(ThanhTraCoiThiColumn.LyDo, mock.LyDo.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(ThanhTraCoiThiColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(ThanhTraCoiThiColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(ThanhTraCoiThiColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				if(mock.XacNhan != null)
					query.AppendEquals(ThanhTraCoiThiColumn.XacNhan, mock.XacNhan.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(ThanhTraCoiThiColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(ThanhTraCoiThiColumn.SoTiet, mock.SoTiet.ToString());
				
				TList<ThanhTraCoiThi> results = DataRepository.ThanhTraCoiThiProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed ThanhTraCoiThi Entity with mock values.
		///</summary>
		static public ThanhTraCoiThi CreateMockInstance_Generated(TransactionManager tm)
		{		
			ThanhTraCoiThi mock = new ThanhTraCoiThi();
						
			mock.Examination = TestUtility.Instance.RandomNumber();
			mock.MaCanBoCoiThi = TestUtility.Instance.RandomString(9, false);;
			mock.NgayThi = TestUtility.Instance.RandomString(10, false);;
			mock.ThoiGianBatDau = TestUtility.Instance.RandomString(24, false);;
			mock.MaPhong = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(249, false);;
			mock.ThoiGianLamBai = TestUtility.Instance.RandomString(10, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.MaLopSinhVien = TestUtility.Instance.RandomString(249, false);;
			mock.SoLuongSinhVien = TestUtility.Instance.RandomNumber();
			mock.MaViPham = TestUtility.Instance.RandomString(9, false);;
			mock.MaHinhThucViPhamHrm = Guid.NewGuid();
			mock.SiSoThanhTra = TestUtility.Instance.RandomNumber();
			mock.ThoiDiemGhiNhan = TestUtility.Instance.RandomString(249, false);;
			mock.LyDo = TestUtility.Instance.RandomString(499, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.XacNhan = TestUtility.Instance.RandomBoolean();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			
		
			// create a temporary collection and add the item to it
			TList<ThanhTraCoiThi> tempMockCollection = new TList<ThanhTraCoiThi>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (ThanhTraCoiThi)mock;
		}
		
		
		///<summary>
		///  Update the Typed ThanhTraCoiThi Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, ThanhTraCoiThi mock)
		{
			mock.NgayThi = TestUtility.Instance.RandomString(10, false);;
			mock.ThoiGianBatDau = TestUtility.Instance.RandomString(24, false);;
			mock.MaPhong = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(249, false);;
			mock.ThoiGianLamBai = TestUtility.Instance.RandomString(10, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.MaLopSinhVien = TestUtility.Instance.RandomString(249, false);;
			mock.SoLuongSinhVien = TestUtility.Instance.RandomNumber();
			mock.MaViPham = TestUtility.Instance.RandomString(9, false);;
			mock.MaHinhThucViPhamHrm = Guid.NewGuid();
			mock.SiSoThanhTra = TestUtility.Instance.RandomNumber();
			mock.ThoiDiemGhiNhan = TestUtility.Instance.RandomString(249, false);;
			mock.LyDo = TestUtility.Instance.RandomString(499, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.XacNhan = TestUtility.Instance.RandomBoolean();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			
		}
		#endregion
    }
}
