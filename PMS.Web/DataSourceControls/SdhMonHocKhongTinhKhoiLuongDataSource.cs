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
	/// Represents the DataRepository.SdhMonHocKhongTinhKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhMonHocKhongTinhKhoiLuongDataSourceDesigner))]
	public class SdhMonHocKhongTinhKhoiLuongDataSource : ProviderDataSource<SdhMonHocKhongTinhKhoiLuong, SdhMonHocKhongTinhKhoiLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongDataSource class.
		/// </summary>
		public SdhMonHocKhongTinhKhoiLuongDataSource() : base(new SdhMonHocKhongTinhKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhMonHocKhongTinhKhoiLuongDataSourceView used by the SdhMonHocKhongTinhKhoiLuongDataSource.
		/// </summary>
		protected SdhMonHocKhongTinhKhoiLuongDataSourceView SdhMonHocKhongTinhKhoiLuongView
		{
			get { return ( View as SdhMonHocKhongTinhKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhMonHocKhongTinhKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public SdhMonHocKhongTinhKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				SdhMonHocKhongTinhKhoiLuongSelectMethod selectMethod = SdhMonHocKhongTinhKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhMonHocKhongTinhKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhMonHocKhongTinhKhoiLuongDataSourceView class that is to be
		/// used by the SdhMonHocKhongTinhKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the SdhMonHocKhongTinhKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhMonHocKhongTinhKhoiLuong, SdhMonHocKhongTinhKhoiLuongKey> GetNewDataSourceView()
		{
			return new SdhMonHocKhongTinhKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhMonHocKhongTinhKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhMonHocKhongTinhKhoiLuongDataSourceView : ProviderDataSourceView<SdhMonHocKhongTinhKhoiLuong, SdhMonHocKhongTinhKhoiLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhMonHocKhongTinhKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhMonHocKhongTinhKhoiLuongDataSourceView(SdhMonHocKhongTinhKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhMonHocKhongTinhKhoiLuongDataSource SdhMonHocKhongTinhKhoiLuongOwner
		{
			get { return Owner as SdhMonHocKhongTinhKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhMonHocKhongTinhKhoiLuongSelectMethod SelectMethod
		{
			get { return SdhMonHocKhongTinhKhoiLuongOwner.SelectMethod; }
			set { SdhMonHocKhongTinhKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhMonHocKhongTinhKhoiLuongService SdhMonHocKhongTinhKhoiLuongProvider
		{
			get { return Provider as SdhMonHocKhongTinhKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhMonHocKhongTinhKhoiLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhMonHocKhongTinhKhoiLuong> results = null;
			SdhMonHocKhongTinhKhoiLuong item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case SdhMonHocKhongTinhKhoiLuongSelectMethod.Get:
					SdhMonHocKhongTinhKhoiLuongKey entityKey  = new SdhMonHocKhongTinhKhoiLuongKey();
					entityKey.Load(values);
					item = SdhMonHocKhongTinhKhoiLuongProvider.Get(entityKey);
					results = new TList<SdhMonHocKhongTinhKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhMonHocKhongTinhKhoiLuongSelectMethod.GetAll:
                    results = SdhMonHocKhongTinhKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhMonHocKhongTinhKhoiLuongSelectMethod.GetPaged:
					results = SdhMonHocKhongTinhKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhMonHocKhongTinhKhoiLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhMonHocKhongTinhKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhMonHocKhongTinhKhoiLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhMonHocKhongTinhKhoiLuongSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = SdhMonHocKhongTinhKhoiLuongProvider.GetById(_id);
					results = new TList<SdhMonHocKhongTinhKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
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
			if ( SelectMethod == SdhMonHocKhongTinhKhoiLuongSelectMethod.Get || SelectMethod == SdhMonHocKhongTinhKhoiLuongSelectMethod.GetById )
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
				SdhMonHocKhongTinhKhoiLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhMonHocKhongTinhKhoiLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhMonHocKhongTinhKhoiLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhMonHocKhongTinhKhoiLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhMonHocKhongTinhKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhMonHocKhongTinhKhoiLuongDataSource class.
	/// </summary>
	public class SdhMonHocKhongTinhKhoiLuongDataSourceDesigner : ProviderDataSourceDesigner<SdhMonHocKhongTinhKhoiLuong, SdhMonHocKhongTinhKhoiLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongDataSourceDesigner class.
		/// </summary>
		public SdhMonHocKhongTinhKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhMonHocKhongTinhKhoiLuongSelectMethod SelectMethod
		{
			get { return ((SdhMonHocKhongTinhKhoiLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhMonHocKhongTinhKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhMonHocKhongTinhKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the SdhMonHocKhongTinhKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class SdhMonHocKhongTinhKhoiLuongDataSourceActionList : DesignerActionList
	{
		private SdhMonHocKhongTinhKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhMonHocKhongTinhKhoiLuongDataSourceActionList(SdhMonHocKhongTinhKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhMonHocKhongTinhKhoiLuongSelectMethod SelectMethod
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

	#endregion SdhMonHocKhongTinhKhoiLuongDataSourceActionList
	
	#endregion SdhMonHocKhongTinhKhoiLuongDataSourceDesigner
	
	#region SdhMonHocKhongTinhKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhMonHocKhongTinhKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum SdhMonHocKhongTinhKhoiLuongSelectMethod
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
		GetById
	}
	
	#endregion SdhMonHocKhongTinhKhoiLuongSelectMethod

	#region SdhMonHocKhongTinhKhoiLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhMonHocKhongTinhKhoiLuongFilter : SqlFilter<SdhMonHocKhongTinhKhoiLuongColumn>
	{
	}
	
	#endregion SdhMonHocKhongTinhKhoiLuongFilter

	#region SdhMonHocKhongTinhKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhMonHocKhongTinhKhoiLuongExpressionBuilder : SqlExpressionBuilder<SdhMonHocKhongTinhKhoiLuongColumn>
	{
	}
	
	#endregion SdhMonHocKhongTinhKhoiLuongExpressionBuilder	

	#region SdhMonHocKhongTinhKhoiLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhMonHocKhongTinhKhoiLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhMonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhMonHocKhongTinhKhoiLuongProperty : ChildEntityProperty<SdhMonHocKhongTinhKhoiLuongChildEntityTypes>
	{
	}
	
	#endregion SdhMonHocKhongTinhKhoiLuongProperty
}

