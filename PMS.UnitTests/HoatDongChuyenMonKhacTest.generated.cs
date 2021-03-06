﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file HoatDongChuyenMonKhacTest.cs instead.
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
    /// Provides tests for the and <see cref="HoatDongChuyenMonKhac"/> objects (entity, collection and repository).
    /// </summary>
   public partial class HoatDongChuyenMonKhacTest
    {
    	// the HoatDongChuyenMonKhac instance used to test the repository.
		protected HoatDongChuyenMonKhac mock;
		
		// the TList<HoatDongChuyenMonKhac> instance used to test the repository.
		protected TList<HoatDongChuyenMonKhac> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the HoatDongChuyenMonKhac Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock HoatDongChuyenMonKhac entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.HoatDongChuyenMonKhacProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.HoatDongChuyenMonKhacProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all HoatDongChuyenMonKhac objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.HoatDongChuyenMonKhacProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.HoatDongChuyenMonKhacProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.HoatDongChuyenMonKhacProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all HoatDongChuyenMonKhac children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.HoatDongChuyenMonKhacProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.HoatDongChuyenMonKhacProvider.DeepLoading += new EntityProviderBaseCore<HoatDongChuyenMonKhac, HoatDongChuyenMonKhacKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.HoatDongChuyenMonKhacProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("HoatDongChuyenMonKhac instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.HoatDongChuyenMonKhacProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock HoatDongChuyenMonKhac entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				HoatDongChuyenMonKhac mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.HoatDongChuyenMonKhacProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.HoatDongChuyenMonKhacProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.HoatDongChuyenMonKhacProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock HoatDongChuyenMonKhac entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (HoatDongChuyenMonKhac)CreateMockInstance(tm);
				DataRepository.HoatDongChuyenMonKhacProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.HoatDongChuyenMonKhacProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.HoatDongChuyenMonKhacProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock HoatDongChuyenMonKhac entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HoatDongChuyenMonKhac.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock HoatDongChuyenMonKhac entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HoatDongChuyenMonKhac.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<HoatDongChuyenMonKhac>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a HoatDongChuyenMonKhac collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HoatDongChuyenMonKhacCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<HoatDongChuyenMonKhac> mockCollection = new TList<HoatDongChuyenMonKhac>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<HoatDongChuyenMonKhac> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a HoatDongChuyenMonKhac collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HoatDongChuyenMonKhacCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<HoatDongChuyenMonKhac>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<HoatDongChuyenMonKhac> mockCollection = (TList<HoatDongChuyenMonKhac>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<HoatDongChuyenMonKhac> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				HoatDongChuyenMonKhac entity = CreateMockInstance(tm);
				bool result = DataRepository.HoatDongChuyenMonKhacProvider.Insert(tm, entity);
				
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
				HoatDongChuyenMonKhac entity = CreateMockInstance(tm);
				bool result = DataRepository.HoatDongChuyenMonKhacProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				HoatDongChuyenMonKhac t0 = DataRepository.HoatDongChuyenMonKhacProvider.GetById(tm, entity.Id);
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
				
				HoatDongChuyenMonKhac entity = mock.Copy() as HoatDongChuyenMonKhac;
				entity = (HoatDongChuyenMonKhac)mock.Clone();
				Assert.IsTrue(HoatDongChuyenMonKhac.ValueEquals(entity, mock), "Clone is not working");
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
				HoatDongChuyenMonKhac mock = CreateMockInstance(tm);
				bool result = DataRepository.HoatDongChuyenMonKhacProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				HoatDongChuyenMonKhacQuery query = new HoatDongChuyenMonKhacQuery();
			
				query.AppendEquals(HoatDongChuyenMonKhacColumn.Id, mock.Id.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(HoatDongChuyenMonKhacColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(HoatDongChuyenMonKhacColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaGiangVien != null)
					query.AppendEquals(HoatDongChuyenMonKhacColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.TenHoatDong != null)
					query.AppendEquals(HoatDongChuyenMonKhacColumn.TenHoatDong, mock.TenHoatDong.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(HoatDongChuyenMonKhacColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(HoatDongChuyenMonKhacColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(HoatDongChuyenMonKhacColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(HoatDongChuyenMonKhacColumn.GhiChu, mock.GhiChu.ToString());
				
				TList<HoatDongChuyenMonKhac> results = DataRepository.HoatDongChuyenMonKhacProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed HoatDongChuyenMonKhac Entity with mock values.
		///</summary>
		static public HoatDongChuyenMonKhac CreateMockInstance_Generated(TransactionManager tm)
		{		
			HoatDongChuyenMonKhac mock = new HoatDongChuyenMonKhac();
						
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.TenHoatDong = TestUtility.Instance.RandomString(249, false);;
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(49, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			
		
			// create a temporary collection and add the item to it
			TList<HoatDongChuyenMonKhac> tempMockCollection = new TList<HoatDongChuyenMonKhac>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (HoatDongChuyenMonKhac)mock;
		}
		
		
		///<summary>
		///  Update the Typed HoatDongChuyenMonKhac Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, HoatDongChuyenMonKhac mock)
		{
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.TenHoatDong = TestUtility.Instance.RandomString(249, false);;
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(49, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			
		}
		#endregion
    }
}
