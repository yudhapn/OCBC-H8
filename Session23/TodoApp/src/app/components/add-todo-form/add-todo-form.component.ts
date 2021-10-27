import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  Output,
} from '@angular/core';
import { Todo } from 'src/app/models/Todo';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css'],
})
export class AddTodoFormComponent implements OnChanges {
  @Input() selectedIndex: number = -1;
  @Input() isEditMode: boolean = false;
  @Input() inputTodo: Todo = {
    content: '',
    completed: false,
  };
  @Output() newTodoEvent = new EventEmitter<Todo>();
  @Output() editTodoEvent = new EventEmitter<any>();
  contentTodo: string = '';

  onAddTodo() {
    const todo: Todo = {
      content: this.contentTodo,
      completed: false,
    };

    this.newTodoEvent.emit(todo);
  }

  onEditTodo() {
    this.inputTodo.content = this.contentTodo;
    this.editTodoEvent.emit({ id: this.selectedIndex, todo: this.inputTodo });
  }

  ngOnChanges(): void {
    this.contentTodo = this.inputTodo.content;
  }
}
