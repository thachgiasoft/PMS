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
	/// Represents the DataRepository.GiangVienBiChanTienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienBiChanTienDataSourceDesigner))]
	public class GiangVienBiChanTienDataSource : ProviderDataSource<GiangVienBiChanTien, GiangVienBiChanTienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienDataSource class.
		/// </summary>
		public GiangVienBiChanTienDataSource() : base(new GiangVienBiChanTienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienBiChanTienDataSourceView used by the GiangVienBiChanTienDataSource.
		/// </summary>
		protected GiangVienBiChanTienDataSourceView GiangVienBiChanTienView
		{
			get { return ( View as GiangVienBiChanTienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienBiChanTienDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienBiChanTienSelectMethod SelectMethod
		{
			get
			{
				GiangVienBiChanTienSelectMethod selectMethod = GiangVienBiChanTienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienBiChanTienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienBiChanTienDataSourceView class that is to be
		/// used by the GiangVienBiChanTienDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienBiChanTienDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienBiChanTien, GiangVienBiChanTienKey> GetNewDataSourceView()
		{
			return new GiangVienBiChanTienDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienBiChanTienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienBiChanTienDataSourceView : ProviderDataSourceView<GiangVienBiChanTien, GiangVienBiChanTienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienBiChanTienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienBiChanTienDataSourceView(GiangVienBiChanTienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienBiChanTienDataSource GiangVienBiChanTienOwner
		{
			get { return Owner as GiangVienBiChanTienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienBiChanTienSelectMethod SelectMethod
		{
			get { return GiangVienBiChanTienOwner.SelectMethod; }
			set { GiangVienBiChanTienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienBiChanTienService GiangVienBiChanTienProvider
		{
			get { return Provider as GiangVienBiChanTienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienBiChanTien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienBiChanTien> results = null;
			GiangVienBiChanTien item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case GiangVienBiChanTienSelectMethod.Get:
					GiangVienBiChanTienKey entityKey  = new GiangVienBiChanTienKey();
					entityKey.Load(values);
					item = GiangVienBiChanTienProvider.Get(entityKey);
					results = new TList<GiangVienBiChanTien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienBiChanTienSelectMethod.GetAll:
                    results = GiangVienBiChanTienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienBiChanTienSelectMethod.GetPaged:
					results = GiangVienBiChanTienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienBiChanTienSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienBiChanTienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienBiChanTienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienBiChanTienSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienBiChanTienProvider.GetById(_id);
					results = new TList<GiangVienBiChanTien>();
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
			if ( SelectMethod == GiangVienBiChanTienSelectMethod.Get || SelectMethod == GiangVienBiChanTienSelectMethod.GetById )
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
				GiangVienBiChanTien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienBiChanTienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienBiChanTien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienBiChanTienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienBiChanTienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienBiChanTienDataSource class.
	/// </summary>
	public class GiangVienBiChanTienDataSourceDesigner : ProviderDataSourceDesigner<GiangVienBiChanTien, GiangVienBiChanTienKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienDataSourceDesigner class.
		/// </summary>
		public GiangVienBiChanTienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienBiChanTienSelectMethod SelectMethod
		{
			get { return ((GiangVienBiChanTienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienBiChanTienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienBiChanTienDataSourceActionList

	/// <summary>
	/// Supports the GiangVienBiChanTienDataSourceDesigner class.
	/// </summary>
	internal class GiangVienBiChanTienDataSourceActionList : DesignerActionList
	{
		private GiangVienBiChanTienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienBiChanTienDataSourceActionList(GiangVienBiChanTienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienBiChanTienSelectMethod SelectMethod
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

	#endregion GiangVienBiChanTienDataSourceActionList
	
	#endregion GiangVienBiChanTienDataSourceDesigner
	
	#region GiangVienBiChanTienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienBiChanTienDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienBiChanTienSelectMethod
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
	
	#endregion GiangVienBiChanTienSelectMethod

	#region GiangVienBiChanTienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienBiChanTien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienBiChanTienFilter : SqlFilter<GiangVienBiChanTienColumn>
	{
	}
	
	#endregion GiangVienBiChanTienFilter

	#region GiangVienBiChanTienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienBiChanTien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienBiChanTienExpressionBuilder : SqlExpressionBuilder<GiangVienBiChanTienColumn>
	{
	}
	
	#endregion GiangVienBiChanTienExpressionBuilder	

	#region GiangVienBiChanTienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienBiChanTienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienBiChanTien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienBiChanTienProperty : ChildEntityProperty<GiangVienBiChanTienChildEntityTypes>
	{
	}
	
	#endregion GiangVienBiChanTienProperty
}

