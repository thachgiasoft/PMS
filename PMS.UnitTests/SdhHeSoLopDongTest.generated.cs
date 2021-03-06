﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SdhHeSoLopDongTest.cs instead.
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
    /// Provides tests for the and <see cref="SdhHeSoLopDong"/> objects (entity, collection and repository).
    /// </summary>
   public partial class SdhHeSoLopDongTest
    {
    	// the SdhHeSoLopDong instance used to test the repository.
		protected SdhHeSoLopDong mock;
		
		// the TList<SdhHeSoLopDong> instance used to test the repository.
		protected TList<SdhHeSoLopDong> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the SdhHeSoLopDong Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock SdhHeSoLopDong entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhHeSoLopDongProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.SdhHeSoLopDongProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all SdhHeSoLopDong objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.SdhHeSoLopDongProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.SdhHeSoLopDongProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.SdhHeSoLopDongProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all SdhHeSoLopDong children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.SdhHeSoLopDongProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.SdhHeSoLopDongProvider.DeepLoading += new EntityProviderBaseCore<SdhHeSoLopDong, SdhHeSoLopDongKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.SdhHeSoLopDongProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("SdhHeSoLopDong instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.SdhHeSoLopDongProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock SdhHeSoLopDong entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhHeSoLopDong mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhHeSoLopDongProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.SdhHeSoLopDongProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.SdhHeSoLopDongProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock SdhHeSoLopDong entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (SdhHeSoLopDong)CreateMockInstance(tm);
				DataRepository.SdhHeSoLopDongProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.SdhHeSoLopDongProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.SdhHeSoLopDongProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock SdhHeSoLopDong entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhHeSoLopDong.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock SdhHeSoLopDong entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhHeSoLopDong.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<SdhHeSoLopDong>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a SdhHeSoLopDong collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhHeSoLopDongCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<SdhHeSoLopDong> mockCollection = new TList<SdhHeSoLopDong>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<SdhHeSoLopDong> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a SdhHeSoLopDong collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhHeSoLopDongCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<SdhHeSoLopDong>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<SdhHeSoLopDong> mockCollection = (TList<SdhHeSoLopDong>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<SdhHeSoLopDong> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhHeSoLopDong entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhHeSoLopDongProvider.Insert(tm, entity);
				
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
				SdhHeSoLopDong entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhHeSoLopDongProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				SdhHeSoLopDong t0 = DataRepository.SdhHeSoLopDongProvider.GetByMaHeSo(tm, entity.MaHeSo);
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
				
				SdhHeSoLopDong entity = mock.Copy() as SdhHeSoLopDong;
				entity = (SdhHeSoLopDong)mock.Clone();
				Assert.IsTrue(SdhHeSoLopDong.ValueEquals(entity, mock), "Clone is not working");
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
				SdhHeSoLopDong mock = CreateMockInstance(tm);
				bool result = DataRepository.SdhHeSoLopDongProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				SdhHeSoLopDongQuery query = new SdhHeSoLopDongQuery();
			
				query.AppendEquals(SdhHeSoLopDongColumn.MaHeSo, mock.MaHeSo.ToString());
				if(mock.Stt != null)
					query.AppendEquals(SdhHeSoLopDongColumn.Stt, mock.Stt.ToString());
				query.AppendEquals(SdhHeSoLopDongColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.MaBacDaoTao != null)
					query.AppendEquals(SdhHeSoLopDongColumn.MaBacDaoTao, mock.MaBacDaoTao.ToString());
				if(mock.MaNhomMonHoc != null)
					query.AppendEquals(SdhHeSoLopDongColumn.MaNhomMonHoc, mock.MaNhomMonHoc.ToString());
				if(mock.TuKhoan != null)
					query.AppendEquals(SdhHeSoLopDongColumn.TuKhoan, mock.TuKhoan.ToString());
				if(mock.DenKhoan != null)
					query.AppendEquals(SdhHeSoLopDongColumn.DenKhoan, mock.DenKhoan.ToString());
				if(mock.HeSo != null)
					query.AppendEquals(SdhHeSoLopDongColumn.HeSo, mock.HeSo.ToString());
				if(mock.NgayBdApDung != null)
					query.AppendEquals(SdhHeSoLopDongColumn.NgayBdApDung, mock.NgayBdApDung.ToString());
				if(mock.NgayKtApDung != null)
					query.AppendEquals(SdhHeSoLopDongColumn.NgayKtApDung, mock.NgayKtApDung.ToString());
				if(mock.MaLoaiKhoiLuong != null)
					query.AppendEquals(SdhHeSoLopDongColumn.MaLoaiKhoiLuong, mock.MaLoaiKhoiLuong.ToString());
				if(mock.HocKyApDung != null)
					query.AppendEquals(SdhHeSoLopDongColumn.HocKyApDung, mock.HocKyApDung.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(SdhHeSoLopDongColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(SdhHeSoLopDongColumn.HocKy, mock.HocKy.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(SdhHeSoLopDongColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(SdhHeSoLopDongColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				
				TList<SdhHeSoLopDong> results = DataRepository.SdhHeSoLopDongProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed SdhHeSoLopDong Entity with mock values.
		///</summary>
		static public SdhHeSoLopDong CreateMockInstance_Generated(TransactionManager tm)
		{		
			SdhHeSoLopDong mock = new SdhHeSoLopDong();
						
			mock.Stt = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(24, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TuKhoan = TestUtility.Instance.RandomNumber();
			mock.DenKhoan = TestUtility.Instance.RandomNumber();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayBdApDung = TestUtility.Instance.RandomDateTime();
			mock.NgayKtApDung = TestUtility.Instance.RandomDateTime();
			mock.MaLoaiKhoiLuong = TestUtility.Instance.RandomString(126, false);;
			mock.HocKyApDung = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
		
			// create a temporary collection and add the item to it
			TList<SdhHeSoLopDong> tempMockCollection = new TList<SdhHeSoLopDong>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (SdhHeSoLopDong)mock;
		}
		
		
		///<summary>
		///  Update the Typed SdhHeSoLopDong Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, SdhHeSoLopDong mock)
		{
			mock.Stt = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(24, false);;
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TuKhoan = TestUtility.Instance.RandomNumber();
			mock.DenKhoan = TestUtility.Instance.RandomNumber();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayBdApDung = TestUtility.Instance.RandomDateTime();
			mock.NgayKtApDung = TestUtility.Instance.RandomDateTime();
			mock.MaLoaiKhoiLuong = TestUtility.Instance.RandomString(126, false);;
			mock.HocKyApDung = TestUtility.Instance.RandomString(24, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
		}
		#endregion
    }
}
