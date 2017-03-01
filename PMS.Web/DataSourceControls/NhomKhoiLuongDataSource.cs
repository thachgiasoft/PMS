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
	/// Represents the DataRepository.NhomKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(NhomKhoiLuongDataSourceDesigner))]
	public class NhomKhoiLuongDataSource : ProviderDataSource<NhomKhoiLuong, NhomKhoiLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongDataSource class.
		/// </summary>
		public NhomKhoiLuongDataSource() : base(new NhomKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the NhomKhoiLuongDataSourceView used by the NhomKhoiLuongDataSource.
		/// </summary>
		protected NhomKhoiLuongDataSourceView NhomKhoiLuongView
		{
			get { return ( View as NhomKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the NhomKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public NhomKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				NhomKhoiLuongSelectMethod selectMethod = NhomKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (NhomKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the NhomKhoiLuongDataSourceView class that is to be
		/// used by the NhomKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the NhomKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<NhomKhoiLuong, NhomKhoiLuongKey> GetNewDataSourceView()
		{
			return new NhomKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the NhomKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class NhomKhoiLuongDataSourceView : ProviderDataSourceView<NhomKhoiLuong, NhomKhoiLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the NhomKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public NhomKhoiLuongDataSourceView(NhomKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal NhomKhoiLuongDataSource NhomKhoiLuongOwner
		{
			get { return Owner as NhomKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal NhomKhoiLuongSelectMethod SelectMethod
		{
			get { return NhomKhoiLuongOwner.SelectMethod; }
			set { NhomKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal NhomKhoiLuongService NhomKhoiLuongProvider
		{
			get { return Provider as NhomKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<NhomKhoiLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<NhomKhoiLuong> results = null;
			NhomKhoiLuong item;
			count = 0;
			
			System.Int32 _maNhom;

			switch ( SelectMethod )
			{
				case NhomKhoiLuongSelectMethod.Get:
					NhomKhoiLuongKey entityKey  = new NhomKhoiLuongKey();
					entityKey.Load(values);
					item = NhomKhoiLuongProvider.Get(entityKey);
					results = new TList<NhomKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case NhomKhoiLuongSelectMethod.GetAll:
                    results = NhomKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case NhomKhoiLuongSelectMethod.GetPaged:
					results = NhomKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case NhomKhoiLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = NhomKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = NhomKhoiLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case NhomKhoiLuongSelectMethod.GetByMaNhom:
					_maNhom = ( values["MaNhom"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhom"], typeof(System.Int32)) : (int)0;
					item = NhomKhoiLuongProvider.GetByMaNhom(_maNhom);
					results = new TList<NhomKhoiLuong>();
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
			if ( SelectMethod == NhomKhoiLuongSelectMethod.Get || SelectMethod == NhomKhoiLuongSelectMethod.GetByMaNhom )
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
				NhomKhoiLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					NhomKhoiLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<NhomKhoiLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			NhomKhoiLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region NhomKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the NhomKhoiLuongDataSource class.
	/// </summary>
	public class NhomKhoiLuongDataSourceDesigner : ProviderDataSourceDesigner<NhomKhoiLuong, NhomKhoiLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongDataSourceDesigner class.
		/// </summary>
		public NhomKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NhomKhoiLuongSelectMethod SelectMethod
		{
			get { return ((NhomKhoiLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new NhomKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region NhomKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the NhomKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class NhomKhoiLuongDataSourceActionList : DesignerActionList
	{
		private NhomKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the NhomKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public NhomKhoiLuongDataSourceActionList(NhomKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NhomKhoiLuongSelectMethod SelectMethod
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

	#endregion NhomKhoiLuongDataSourceActionList
	
	#endregion NhomKhoiLuongDataSourceDesigner
	
	#region NhomKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the NhomKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum NhomKhoiLuongSelectMethod
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
		/// Represents the GetByMaNhom method.
		/// </summary>
		GetByMaNhom
	}
	
	#endregion NhomKhoiLuongSelectMethod

	#region NhomKhoiLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomKhoiLuongFilter : SqlFilter<NhomKhoiLuongColumn>
	{
	}
	
	#endregion NhomKhoiLuongFilter

	#region NhomKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NhomKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomKhoiLuongExpressionBuilder : SqlExpressionBuilder<NhomKhoiLuongColumn>
	{
	}
	
	#endregion NhomKhoiLuongExpressionBuilder	

	#region NhomKhoiLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;NhomKhoiLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="NhomKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NhomKhoiLuongProperty : ChildEntityProperty<NhomKhoiLuongChildEntityTypes>
	{
	}
	
	#endregion NhomKhoiLuongProperty
}

