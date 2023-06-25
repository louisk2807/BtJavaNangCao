<?php

use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

//Route::get('/', function () {
//    return view('welcome');
//});

// Classroom
Route::get('classrooms/index', [\App\Http\Controllers\ClassroomsController::class, 'index'])->name('classroom.index');
Route::get('classrooms/create', [\App\Http\Controllers\ClassroomsController::class, 'create'])->name('classroom.create');
Route::post('classrooms/create', [\App\Http\Controllers\ClassroomsController::class, 'store'])->name('classroom.store');
Route::get('classrooms/{id}/edit', [\App\Http\Controllers\ClassroomsController::class, 'edit'])->name('classroom.edit');
Route::put('classrooms/{id}/edit', [\App\Http\Controllers\ClassroomsController::class, 'update'])->name('classroom.update');
Route::get('classrooms/{id}/delete', [\App\Http\Controllers\ClassroomsController::class, 'destroy'])->name('classroom.destroy');

// Student
Route::get('students/index', [\App\Http\Controllers\StudentsController::class, 'index'])->name('student.index');
Route::get('students/create', [\App\Http\Controllers\StudentsController::class, 'create'])->name('student.create');
Route::post('students/create', [\App\Http\Controllers\StudentsController::class, 'store'])->name('student.store');
Route::get('students/{id}/edit', [\App\Http\Controllers\StudentsController::class, 'edit'])->name('student.edit');
Route::put('students/{id}/edit', [\App\Http\Controllers\StudentsController::class, 'update'])->name('student.update');
Route::get('students/{id}/delete', [\App\Http\Controllers\StudentsController::class, 'destroy'])->name('student.destroy');
