﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file DuTruGioGiangTruocLopHocPhanTest.cs instead.
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
    /// Provides tests for the and <see cref="DuTruGioGiangTruocLopHocPhan"/> objects (entity, collection and repository).
    /// </summary>
   public partial class DuTruGioGiangTruocLopHocPhanTest
    {
    	// the DuTruGioGiangTruocLopHocPhan instance used to test the repository.
		protected DuTruGioGiangTruocLopHocPhan mock;
		
		// the TList<DuTruGioGiangTruocLopHocPhan> instance used to test the repository.
		protected TList<DuTruGioGiangTruocLopHocPhan> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the DuTruGioGiangTruocLopHocPhan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock DuTruGioGiangTruocLopHocPhan entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all DuTruGioGiangTruocLopHocPhan objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.DuTruGioGiangTruocLopHocPhanProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all DuTruGioGiangTruocLopHocPhan children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.DuTruGioGiangTruocLopHocPhanProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.DuTruGioGiangTruocLopHocPhanProvider.DeepLoading += new EntityProviderBaseCore<DuTruGioGiangTruocLopHocPhan, DuTruGioGiangTruocLopHocPhanKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.DuTruGioGiangTruocLopHocPhanProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("DuTruGioGiangTruocLopHocPhan instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.DuTruGioGiangTruocLopHocPhanProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock DuTruGioGiangTruocLopHocPhan entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DuTruGioGiangTruocLopHocPhan mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock DuTruGioGiangTruocLopHocPhan entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (DuTruGioGiangTruocLopHocPhan)CreateMockInstance(tm);
				DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock DuTruGioGiangTruocLopHocPhan entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DuTruGioGiangTruocLopHocPhan.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock DuTruGioGiangTruocLopHocPhan entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DuTruGioGiangTruocLopHocPhan.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<DuTruGioGiangTruocLopHocPhan>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a DuTruGioGiangTruocLopHocPhan collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DuTruGioGiangTruocLopHocPhanCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<DuTruGioGiangTruocLopHocPhan> mockCollection = new TList<DuTruGioGiangTruocLopHocPhan>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<DuTruGioGiangTruocLopHocPhan> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a DuTruGioGiangTruocLopHocPhan collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DuTruGioGiangTruocLopHocPhanCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<DuTruGioGiangTruocLopHocPhan>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<DuTruGioGiangTruocLopHocPhan> mockCollection = (TList<DuTruGioGiangTruocLopHocPhan>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<DuTruGioGiangTruocLopHocPhan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DuTruGioGiangTruocLopHocPhan entity = CreateMockInstance(tm);
				bool result = DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Insert(tm, entity);
				
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
				DuTruGioGiangTruocLopHocPhan entity = CreateMockInstance(tm);
				bool result = DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				DuTruGioGiangTruocLopHocPhan t0 = DataRepository.DuTruGioGiangTruocLopHocPhanProvider.GetById(tm, entity.Id);
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
				
				DuTruGioGiangTruocLopHocPhan entity = mock.Copy() as DuTruGioGiangTruocLopHocPhan;
				entity = (DuTruGioGiangTruocLopHocPhan)mock.Clone();
				Assert.IsTrue(DuTruGioGiangTruocLopHocPhan.ValueEquals(entity, mock), "Clone is not working");
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
				DuTruGioGiangTruocLopHocPhan mock = CreateMockInstance(tm);
				bool result = DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				DuTruGioGiangTruocLopHocPhanQuery query = new DuTruGioGiangTruocLopHocPhanQuery();
			
				query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.Id, mock.Id.ToString());
				if(mock.MaLopSinhVien != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.MaLopSinhVien, mock.MaLopSinhVien.ToString());
				if(mock.TenLopSinhVien != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.TenLopSinhVien, mock.TenLopSinhVien.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.LyThuyet != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.LyThuyet, mock.LyThuyet.ToString());
				if(mock.ThucHanh != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.ThucHanh, mock.ThucHanh.ToString());
				if(mock.SiSo != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.SiSo, mock.SiSo.ToString());
				if(mock.MaBacDaoTao != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.MaBacDaoTao, mock.MaBacDaoTao.ToString());
				if(mock.MaDonVi != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.MaDonVi, mock.MaDonVi.ToString());
				if(mock.HeSoBacDaoTao != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.HeSoBacDaoTao, mock.HeSoBacDaoTao.ToString());
				if(mock.HeSoLopDong != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.HeSoLopDong, mock.HeSoLopDong.ToString());
				if(mock.HeSoMonThucTap != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.HeSoMonThucTap, mock.HeSoMonThucTap.ToString());
				if(mock.HeSoCoVanHocTap != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.HeSoCoVanHocTap, mock.HeSoCoVanHocTap.ToString());
				if(mock.SoTietQuyDoi != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.SoTietQuyDoi, mock.SoTietQuyDoi.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(DuTruGioGiangTruocLopHocPhanColumn.HocKy, mock.HocKy.ToString());
				
				TList<DuTruGioGiangTruocLopHocPhan> results = DataRepository.DuTruGioGiangTruocLopHocPhanProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed DuTruGioGiangTruocLopHocPhan Entity with mock values.
		///</summary>
		static public DuTruGioGiangTruocLopHocPhan CreateMockInstance_Generated(TransactionManager tm)
		{		
			DuTruGioGiangTruocLopHocPhan mock = new DuTruGioGiangTruocLopHocPhan();
						
			mock.MaLopSinhVien = TestUtility.Instance.RandomString(9, false);;
			mock.TenLopSinhVien = TestUtility.Instance.RandomString(24, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(249, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.LyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucHanh = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaDonVi = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoBacDaoTao = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoMonThucTap = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoCoVanHocTap = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
		
			// create a temporary collection and add the item to it
			TList<DuTruGioGiangTruocLopHocPhan> tempMockCollection = new TList<DuTruGioGiangTruocLopHocPhan>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (DuTruGioGiangTruocLopHocPhan)mock;
		}
		
		
		///<summary>
		///  Update the Typed DuTruGioGiangTruocLopHocPhan Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, DuTruGioGiangTruocLopHocPhan mock)
		{
			mock.MaLopSinhVien = TestUtility.Instance.RandomString(9, false);;
			mock.TenLopSinhVien = TestUtility.Instance.RandomString(24, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(249, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.LyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucHanh = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaDonVi = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoBacDaoTao = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoMonThucTap = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoCoVanHocTap = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
		}
		#endregion
    }
}