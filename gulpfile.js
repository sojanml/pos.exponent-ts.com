/// <binding />
var gulp = require('gulp');
var compass = require('gulp-compass');


gulp.task('sass', function () {
  return gulp.src(__dirname + 'POS/sass/**/*')

    .pipe(compass({
      config_file: __dirname + '\\config.rb',
      project: __dirname + '/POS',
      css: 'Content',
      sass: 'sass'
    }));
});

//C:\Web\POS\POS\POS\

//Watch task
gulp.task('default', function () {
  var watcher = gulp.watch('POS/sass/**/*', ['sass']);

  watcher.on('change', function (event) {
    console.log('Changed File: ' + event.path);
  });

  watcher.on('error', function (event) {
    console.log('Error: File ' + event.path + ' was ' + event.type);
  });
  return watcher;
});

