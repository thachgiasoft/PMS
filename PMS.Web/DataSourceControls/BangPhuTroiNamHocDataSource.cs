#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.BangPhuTroiNamHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(BangPhuTroiNamHocDataSourceDesigner))]
	public class BangPhuTroiNamHocDataSource : ProviderDataSource<BangPhuTroiNamHoc, BangPhuTroiNamHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocDataSource class.
		/// </summary>
		public BangPhuTroiNamHocDataSource() : base(new BangPhuTroiNamHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the BangPhuTroiNamHocDataSourceView used by the BangPhuTroiNamHocDataSource.
		/// </summary>
		protected BangPhuTroiNamHocDataSourceView BangPhuTroiNamHocView
		{
			get { return ( View as BangPhuTroiNamHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the BangPhuTroiNamHocDataSource control invokes to retrieve data.
		/// </summary>
		public BangPhuTroiNamHocSelectMethod SelectMethod
		{
			get
			{
				BangPhuTroiNamHocSelectMethod selectMethod = BangPhuTroiNamHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (BangPhuTroiNamHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the BangPhuTroiNamHocDataSourceView class that is to be
		/// used by the BangPhuTroiNamHocDataSource.
		/// </summary>
		/// <returns>An instance of the BangPhuTroiNamHocDataSourceView class.</returns>
		protected override BaseDataSourceView<BangPhuTroiNamHoc, BangPhuTroiNamHocKey> GetNewDataSourceView()
		{
			return new BangPhuTroiNamHocDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the BangPhuTroiNamHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class BangPhuTroiNamHocDataSourceView : ProviderDataSourceView<BangPhuTroiNamHoc, BangPhuTroiNamHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the BangPhuTroiNamHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public BangPhuTroiNamHocDataSourceView(BangPhuTroiNamHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal BangPhuTroiNamHocDataSource BangPhuTroiNamHocOwner
		{
			get { return Owner as BangPhuTroiNamHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal BangPhuTroiNamHocSelectMethod SelectMethod
		{
			get { return BangPhuTroiNamHocOwner.SelectMethod; }
			set { BangPhuTroiNamHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal BangPhuTroiNamHocService BangPhuTroiNamHocProvider
		{
			get { return Provider as BangPhuTroiNamHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<BangPhuTroiNamHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<BangPhuTroiNamHoc> results = null;
			BangPhuTroiNamHoc item;
			count = 0;
			
			System.Int32 _maGiangVien;
			System.String _namHoc;

			switch ( SelectMethod )
			{
				case BangPhuTroiNamHocSelectMethod.Get:
					BangPhuTroiNamHocKey entityKey  = new BangPhuTroiNamHocKey();
					entityKey.Load(values);
					item = BangPhuTroiNamHocProvider.Get(entityKey);
					results = new TList<BangPhuTroiNamHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case BangPhuTroiNamHocSelectMethod.GetAll:
                    results = BangPhuTroiNamHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case BangPhuTroiNamHocSelectMethod.GetPaged:
					results = BangPhuTroiNamHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case BangPhuTroiNamHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = BangPhuTroiNamHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = BangPhuTroiNamHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case BangPhuTroiNamHocSelectMethod.GetByMaGiangVienNamHoc:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					_namHoc = ( values["NamHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String)) : string.Empty;
					item = BangPhuTroiNamHocProvider.GetByMaGiangVienNamHoc(_maGiangVien, _namHoc);
					results = new TList<BangPhuTroiNamHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case BangPhuTroiNamHocSelectMethod.GetByMaGiangVien:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					results = BangPhuTroiNamHocProvider.GetByMaGiangVien(_maGiangVien, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == BangPhuTroiNamHocSelectMethod.Get || SelectMethod == BangPhuTroiNamHocSelectMethod.GetByMaGiangVienNamHoc )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				BangPhuTroiNamHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					BangPhuTroiNamHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<BangPhuTroiNamHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			BangPhuTroiNamHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region BangPhuTroiNamHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the BangPhuTroiNamHocDataSource class.
	/// </summary>
	public class BangPhuTroiNamHocDataSourceDesigner : ProviderDataSourceDesigner<BangPhuTroiNamHoc, BangPhuTroiNamHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocDataSourceDesigner class.
		/// </summary>
		public BangPhuTroiNamHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public BangPhuTroiNamHocSelectMethod SelectMethod
		{
			get { return ((BangPhuTroiNamHocDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new BangPhuTroiNamHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region BangPhuTroiNamHocDataSourceActionList

	/// <summary>
	/// Supports the BangPhuTroiNamHocDataSourceDesigner class.
	/// </summary>
	internal class BangPhuTroiNamHocDataSourceActionList : DesignerActionList
	{
		private BangPhuTroiNamHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public BangPhuTroiNamHocDataSourceActionList(BangPhuTroiNamHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public BangPhuTroiNamHocSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion BangPhuTroiNamHocDataSourceActionList
	
	#endregion BangPhuTroiNamHocDataSourceDesigner
	
	#region BangPhuTroiNamHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the BangPhuTroiNamHocDataSource.SelectMethod property.
	/// </summary>
	public enum BangPhuTroiNamHocSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaGiangVienNamHoc method.
		/// </summary>
		GetByMaGiangVienNamHoc,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion BangPhuTroiNamHocSelectMethod

	#region BangPhuTroiNamHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BangPhuTroiNamHocFilter : SqlFilter<BangPhuTroiNamHocColumn>
	{
	}
	
	#endregion BangPhuTroiNamHocFilter

	#region BangPhuTroiNamHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BangPhuTroiNamHocExpressionBuilder : SqlExpressionBuilder<BangPhuTroiNamHocColumn>
	{
	}
	
	#endregion BangPhuTroiNamHocExpressionBuilder	

	#region BangPhuTroiNamHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;BangPhuTroiNamHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BangPhuTroiNamHocProperty : ChildEntityProperty<BangPhuTroiNamHocChildEntityTypes>
	{
	}
	
	#endregion BangPhuTroiNamHocProperty
}

