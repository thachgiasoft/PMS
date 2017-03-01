﻿#region Using Directives
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
	/// Represents the DataRepository.KhoiLuongGiangDayDoAnTotNghiepProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner))]
	public class KhoiLuongGiangDayDoAnTotNghiepDataSource : ProviderDataSource<KhoiLuongGiangDayDoAnTotNghiep, KhoiLuongGiangDayDoAnTotNghiepKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnTotNghiepDataSource class.
		/// </summary>
		public KhoiLuongGiangDayDoAnTotNghiepDataSource() : base(new KhoiLuongGiangDayDoAnTotNghiepService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongGiangDayDoAnTotNghiepDataSourceView used by the KhoiLuongGiangDayDoAnTotNghiepDataSource.
		/// </summary>
		protected KhoiLuongGiangDayDoAnTotNghiepDataSourceView KhoiLuongGiangDayDoAnTotNghiepView
		{
			get { return ( View as KhoiLuongGiangDayDoAnTotNghiepDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongGiangDayDoAnTotNghiepDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongGiangDayDoAnTotNghiepSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongGiangDayDoAnTotNghiepSelectMethod selectMethod = KhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongGiangDayDoAnTotNghiepSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongGiangDayDoAnTotNghiepDataSourceView class that is to be
		/// used by the KhoiLuongGiangDayDoAnTotNghiepDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongGiangDayDoAnTotNghiepDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongGiangDayDoAnTotNghiep, KhoiLuongGiangDayDoAnTotNghiepKey> GetNewDataSourceView()
		{
			return new KhoiLuongGiangDayDoAnTotNghiepDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongGiangDayDoAnTotNghiepDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongGiangDayDoAnTotNghiepDataSourceView : ProviderDataSourceView<KhoiLuongGiangDayDoAnTotNghiep, KhoiLuongGiangDayDoAnTotNghiepKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnTotNghiepDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongGiangDayDoAnTotNghiepDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongGiangDayDoAnTotNghiepDataSourceView(KhoiLuongGiangDayDoAnTotNghiepDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongGiangDayDoAnTotNghiepDataSource KhoiLuongGiangDayDoAnTotNghiepOwner
		{
			get { return Owner as KhoiLuongGiangDayDoAnTotNghiepDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongGiangDayDoAnTotNghiepSelectMethod SelectMethod
		{
			get { return KhoiLuongGiangDayDoAnTotNghiepOwner.SelectMethod; }
			set { KhoiLuongGiangDayDoAnTotNghiepOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongGiangDayDoAnTotNghiepService KhoiLuongGiangDayDoAnTotNghiepProvider
		{
			get { return Provider as KhoiLuongGiangDayDoAnTotNghiepService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongGiangDayDoAnTotNghiep> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongGiangDayDoAnTotNghiep> results = null;
			KhoiLuongGiangDayDoAnTotNghiep item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2695_NamHoc;
			System.String sp2695_HocKy;

			switch ( SelectMethod )
			{
				case KhoiLuongGiangDayDoAnTotNghiepSelectMethod.Get:
					KhoiLuongGiangDayDoAnTotNghiepKey entityKey  = new KhoiLuongGiangDayDoAnTotNghiepKey();
					entityKey.Load(values);
					item = KhoiLuongGiangDayDoAnTotNghiepProvider.Get(entityKey);
					results = new TList<KhoiLuongGiangDayDoAnTotNghiep>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetAll:
                    results = KhoiLuongGiangDayDoAnTotNghiepProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetPaged:
					results = KhoiLuongGiangDayDoAnTotNghiepProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongGiangDayDoAnTotNghiepSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongGiangDayDoAnTotNghiepProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongGiangDayDoAnTotNghiepProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongGiangDayDoAnTotNghiepProvider.GetById(_id);
					results = new TList<KhoiLuongGiangDayDoAnTotNghiep>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetByNamHocHocKy:
					sp2695_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2695_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KhoiLuongGiangDayDoAnTotNghiepProvider.GetByNamHocHocKy(sp2695_NamHoc, sp2695_HocKy, StartIndex, PageSize);
					break;
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
			if ( SelectMethod == KhoiLuongGiangDayDoAnTotNghiepSelectMethod.Get || SelectMethod == KhoiLuongGiangDayDoAnTotNghiepSelectMethod.GetById )
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
				KhoiLuongGiangDayDoAnTotNghiep entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongGiangDayDoAnTotNghiepProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongGiangDayDoAnTotNghiep> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongGiangDayDoAnTotNghiepProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongGiangDayDoAnTotNghiepDataSource class.
	/// </summary>
	public class KhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongGiangDayDoAnTotNghiep, KhoiLuongGiangDayDoAnTotNghiepKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner class.
		/// </summary>
		public KhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDayDoAnTotNghiepSelectMethod SelectMethod
		{
			get { return ((KhoiLuongGiangDayDoAnTotNghiepDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongGiangDayDoAnTotNghiepDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongGiangDayDoAnTotNghiepDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongGiangDayDoAnTotNghiepDataSourceActionList : DesignerActionList
	{
		private KhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnTotNghiepDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongGiangDayDoAnTotNghiepDataSourceActionList(KhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDayDoAnTotNghiepSelectMethod SelectMethod
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

	#endregion KhoiLuongGiangDayDoAnTotNghiepDataSourceActionList
	
	#endregion KhoiLuongGiangDayDoAnTotNghiepDataSourceDesigner
	
	#region KhoiLuongGiangDayDoAnTotNghiepSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongGiangDayDoAnTotNghiepDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongGiangDayDoAnTotNghiepSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion KhoiLuongGiangDayDoAnTotNghiepSelectMethod

	#region KhoiLuongGiangDayDoAnTotNghiepFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayDoAnTotNghiepFilter : SqlFilter<KhoiLuongGiangDayDoAnTotNghiepColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayDoAnTotNghiepFilter

	#region KhoiLuongGiangDayDoAnTotNghiepExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayDoAnTotNghiepExpressionBuilder : SqlExpressionBuilder<KhoiLuongGiangDayDoAnTotNghiepColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayDoAnTotNghiepExpressionBuilder	

	#region KhoiLuongGiangDayDoAnTotNghiepProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongGiangDayDoAnTotNghiepChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayDoAnTotNghiepProperty : ChildEntityProperty<KhoiLuongGiangDayDoAnTotNghiepChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongGiangDayDoAnTotNghiepProperty
}
