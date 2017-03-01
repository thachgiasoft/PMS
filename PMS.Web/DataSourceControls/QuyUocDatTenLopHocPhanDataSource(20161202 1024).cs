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
	/// Represents the DataRepository.QuyUocDatTenLopHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(QuyUocDatTenLopHocPhanDataSourceDesigner))]
	public class QuyUocDatTenLopHocPhanDataSource : ProviderDataSource<QuyUocDatTenLopHocPhan, QuyUocDatTenLopHocPhanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyUocDatTenLopHocPhanDataSource class.
		/// </summary>
		public QuyUocDatTenLopHocPhanDataSource() : base(new QuyUocDatTenLopHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the QuyUocDatTenLopHocPhanDataSourceView used by the QuyUocDatTenLopHocPhanDataSource.
		/// </summary>
		protected QuyUocDatTenLopHocPhanDataSourceView QuyUocDatTenLopHocPhanView
		{
			get { return ( View as QuyUocDatTenLopHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the QuyUocDatTenLopHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public QuyUocDatTenLopHocPhanSelectMethod SelectMethod
		{
			get
			{
				QuyUocDatTenLopHocPhanSelectMethod selectMethod = QuyUocDatTenLopHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (QuyUocDatTenLopHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the QuyUocDatTenLopHocPhanDataSourceView class that is to be
		/// used by the QuyUocDatTenLopHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the QuyUocDatTenLopHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<QuyUocDatTenLopHocPhan, QuyUocDatTenLopHocPhanKey> GetNewDataSourceView()
		{
			return new QuyUocDatTenLopHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the QuyUocDatTenLopHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class QuyUocDatTenLopHocPhanDataSourceView : ProviderDataSourceView<QuyUocDatTenLopHocPhan, QuyUocDatTenLopHocPhanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyUocDatTenLopHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the QuyUocDatTenLopHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public QuyUocDatTenLopHocPhanDataSourceView(QuyUocDatTenLopHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal QuyUocDatTenLopHocPhanDataSource QuyUocDatTenLopHocPhanOwner
		{
			get { return Owner as QuyUocDatTenLopHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal QuyUocDatTenLopHocPhanSelectMethod SelectMethod
		{
			get { return QuyUocDatTenLopHocPhanOwner.SelectMethod; }
			set { QuyUocDatTenLopHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal QuyUocDatTenLopHocPhanService QuyUocDatTenLopHocPhanProvider
		{
			get { return Provider as QuyUocDatTenLopHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<QuyUocDatTenLopHocPhan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<QuyUocDatTenLopHocPhan> results = null;
			QuyUocDatTenLopHocPhan item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2814_NamHoc;
			System.String sp2814_HocKy;

			switch ( SelectMethod )
			{
				case QuyUocDatTenLopHocPhanSelectMethod.Get:
					QuyUocDatTenLopHocPhanKey entityKey  = new QuyUocDatTenLopHocPhanKey();
					entityKey.Load(values);
					item = QuyUocDatTenLopHocPhanProvider.Get(entityKey);
					results = new TList<QuyUocDatTenLopHocPhan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case QuyUocDatTenLopHocPhanSelectMethod.GetAll:
                    results = QuyUocDatTenLopHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case QuyUocDatTenLopHocPhanSelectMethod.GetPaged:
					results = QuyUocDatTenLopHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case QuyUocDatTenLopHocPhanSelectMethod.Find:
					if ( FilterParameters != null )
						results = QuyUocDatTenLopHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = QuyUocDatTenLopHocPhanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case QuyUocDatTenLopHocPhanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = QuyUocDatTenLopHocPhanProvider.GetById(_id);
					results = new TList<QuyUocDatTenLopHocPhan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case QuyUocDatTenLopHocPhanSelectMethod.GetByNamHocHocKy:
					sp2814_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2814_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = QuyUocDatTenLopHocPhanProvider.GetByNamHocHocKy(sp2814_NamHoc, sp2814_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == QuyUocDatTenLopHocPhanSelectMethod.Get || SelectMethod == QuyUocDatTenLopHocPhanSelectMethod.GetById )
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
				QuyUocDatTenLopHocPhan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					QuyUocDatTenLopHocPhanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<QuyUocDatTenLopHocPhan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			QuyUocDatTenLopHocPhanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region QuyUocDatTenLopHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the QuyUocDatTenLopHocPhanDataSource class.
	/// </summary>
	public class QuyUocDatTenLopHocPhanDataSourceDesigner : ProviderDataSourceDesigner<QuyUocDatTenLopHocPhan, QuyUocDatTenLopHocPhanKey>
	{
		/// <summary>
		/// Initializes a new instance of the QuyUocDatTenLopHocPhanDataSourceDesigner class.
		/// </summary>
		public QuyUocDatTenLopHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyUocDatTenLopHocPhanSelectMethod SelectMethod
		{
			get { return ((QuyUocDatTenLopHocPhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new QuyUocDatTenLopHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region QuyUocDatTenLopHocPhanDataSourceActionList

	/// <summary>
	/// Supports the QuyUocDatTenLopHocPhanDataSourceDesigner class.
	/// </summary>
	internal class QuyUocDatTenLopHocPhanDataSourceActionList : DesignerActionList
	{
		private QuyUocDatTenLopHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the QuyUocDatTenLopHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public QuyUocDatTenLopHocPhanDataSourceActionList(QuyUocDatTenLopHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyUocDatTenLopHocPhanSelectMethod SelectMethod
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

	#endregion QuyUocDatTenLopHocPhanDataSourceActionList
	
	#endregion QuyUocDatTenLopHocPhanDataSourceDesigner
	
	#region QuyUocDatTenLopHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the QuyUocDatTenLopHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum QuyUocDatTenLopHocPhanSelectMethod
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
	
	#endregion QuyUocDatTenLopHocPhanSelectMethod

	#region QuyUocDatTenLopHocPhanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyUocDatTenLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyUocDatTenLopHocPhanFilter : SqlFilter<QuyUocDatTenLopHocPhanColumn>
	{
	}
	
	#endregion QuyUocDatTenLopHocPhanFilter

	#region QuyUocDatTenLopHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyUocDatTenLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyUocDatTenLopHocPhanExpressionBuilder : SqlExpressionBuilder<QuyUocDatTenLopHocPhanColumn>
	{
	}
	
	#endregion QuyUocDatTenLopHocPhanExpressionBuilder	

	#region QuyUocDatTenLopHocPhanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;QuyUocDatTenLopHocPhanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="QuyUocDatTenLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyUocDatTenLopHocPhanProperty : ChildEntityProperty<QuyUocDatTenLopHocPhanChildEntityTypes>
	{
	}
	
	#endregion QuyUocDatTenLopHocPhanProperty
}

